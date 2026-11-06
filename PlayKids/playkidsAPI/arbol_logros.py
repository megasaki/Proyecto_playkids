import json
import sys
import os
import io
import matplotlib
matplotlib.use('Agg')
import matplotlib.pyplot as plt
import networkx as nx

sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')
sys.stdin = io.TextIOWrapper(sys.stdin.buffer, encoding='utf-8')

class NodoLogro:
    def __init__(self, id_logro, titulo, descripcion, completado=False):
        self.id_logro = id_logro          
        self.titulo = titulo              
        self.descripcion = descripcion    
        self.completado = completado      
        self.izquierda = None             
        self.derecha = None               

class ArbolLogrosBST:
    def __init__(self):
        self.raiz = None

    def construir_desde_lista(self, lista_items):
        lista_ordenada = sorted(lista_items, key=lambda x: x["id_logro"])
        self.raiz = self._construir_balanceado_recursivo(lista_ordenada)

    def _construir_balanceado_recursivo(self, lista):
        if not lista:
            return None
        
        medio = len(lista) // 2
        item = lista[medio]
        
        nodo = NodoLogro(
            id_logro=item["id_logro"],
            titulo=item["titulo"],
            descripcion=item["descripcion"],
            completado=item["completado"]
        )
        
        nodo.izquierda = self._construir_balanceado_recursivo(lista[:medio])
        nodo.derecha = self._construir_balanceado_recursivo(lista[medio+1:])
        
        return nodo

    def obtener_inorden(self):
        resultado = []
        self._inorden_recursivo(self.raiz, resultado)
        return resultado

    def _inorden_recursivo(self, nodo, resultado):
        if nodo:
            self._inorden_recursivo(nodo.izquierda, resultado)
            resultado.append({
                "id_logro": nodo.id_logro,
                "titulo": nodo.titulo,
                "descripcion": nodo.descripcion,
                "completado": nodo.completado
            })
            self._inorden_recursivo(nodo.derecha, resultado)

    def generar_grafo_visual(self, ruta_imagen):
        G = nx.DiGraph()
        labels = {}
        colores_nodos = []

        def construir_red(nodo):
            if nodo is None:
                return
            estado = "[Completado]" if nodo.completado else "[Pendiente]"
            labels[nodo.id_logro] = f"ID: {nodo.id_logro}\n{nodo.titulo}\n{estado}"
            colores_nodos.append('#4CAF50' if nodo.completado else '#FFC107')

            if nodo.izquierda:
                G.add_edge(nodo.id_logro, nodo.izquierda.id_logro)
                construir_red(nodo.izquierda)
            if nodo.derecha:
                G.add_edge(nodo.id_logro, nodo.derecha.id_logro)
                construir_red(nodo.derecha)

        construir_red(self.raiz)

        if len(G.nodes) == 0:
            return

        plt.figure(figsize=(7, 5))
        pos = nx.spring_layout(G, seed=42)
        
        nx.draw(G, pos, labels=labels, with_labels=True, node_size=3500, 
                node_color=colores_nodos, font_size=7, font_weight="bold", 
                edge_color="#555555", width=1.5, alpha=0.9)
        
        plt.title("Estructura No Lineal: Árbol de Logros (PlayKids)", fontsize=10, fontweight="bold", color="#333333")
        plt.savefig(ruta_imagen, format="png", bbox_inches='tight', dpi=300)
        plt.close()

if __name__ == "__main__":
    arbol = ArbolLogrosBST()
    logros_data = []

    # 1. Capturar JSON de logros
    if len(sys.argv) > 1:
        try:
            raw_arg = sys.argv[1].replace('\\"', '"')
            logros_data = json.loads(raw_arg)
        except Exception as e:
            print(f"Error procesando JSON en Python: {e}", file=sys.stderr)

    # 2. Capturar ID de usuario
    id_usuario = sys.argv[2] if len(sys.argv) > 2 else "default"

    # 3. Capturar la ruta absoluta exacta enviada por la API
    script_dir = os.path.dirname(os.path.abspath(__file__))
    ruta_absoluta = sys.argv[3] if len(sys.argv) > 3 else os.path.join(script_dir, f"arbol_logros_{id_usuario}.png")

    if not logros_data:
        logros_data = [
            {"id_logro": 10, "titulo": "Leyenda de PlayKids", "descripcion": "Domina ambos minijuegos.", "completado": False},
            {"id_logro": 5, "titulo": "Primer V/F", "descripcion": "Completa la lección 1.", "completado": False},
            {"id_logro": 2, "titulo": "Oído Preciso", "descripcion": "Puntaje máximo en V/F.", "completado": False},
            {"id_logro": 8, "titulo": "Analista Gramatical", "descripcion": "Puntaje >= 4 en V/F.", "completado": False},
            {"id_logro": 15, "titulo": "Primeras Palabras", "descripcion": "Completa la lección 2.", "completado": False},
            {"id_logro": 12, "titulo": "Vocabulario Activo", "descripcion": "Errores < 3 en Selección Múltiple.", "completado": False},
            {"id_logro": 18, "titulo": "Maestro del Vocabulario", "descripcion": "Puntaje máximo en Selección Múltiple.", "completado": False}
        ]

    arbol.construir_desde_lista(logros_data)
    
    # Generar la imagen en la ruta absoluta exacta que la API requiere
    arbol.generar_grafo_visual(ruta_absoluta)

    print(json.dumps(arbol.obtener_inorden(), ensure_ascii=False))