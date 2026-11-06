import json
import sys

class NodoLogro:
    def __init__(self, id_logro, titulo, descripcion, completado=False):
        self.id_logro = id_logro          # Clave numérica para ordenar en el BST (ej. ID del logro)
        self.titulo = titulo              # Nombre del logro (ej. "Vocabulario Nivel 1")
        self.descripcion = descripcion    # Detalle del logro
        self.completado = completado      # Estado de desbloqueo
        self.izquierda = None             # Hijo izquierdo (prerrequisito menor)
        self.derecha = None               # Hijo derecho (prerrequisito mayor)

class ArbolLogrosBST:
    def __init__(self):
        self.raiz = None

    # Método público para insertar
    def insertar(self, id_logro, titulo, descripcion, completado):
        self.raiz = self._insertar_recursivo(self.raiz, id_logro, titulo, descripcion, completado)

    # Función RECURSIVA para insertar nodos en el BST según el ID del logro
    def _insertar_recursivo(self, nodo, id_logro, titulo, descripcion, completado):
        if nodo is None:
            return NodoLogro(id_logro, titulo, descripcion, completado)
        
        if id_logro < nodo.id_logro:
            nodo.izquierda = self._insertar_recursivo(nodo.izquierda, id_logro, titulo, descripcion, completado)
        elif id_logro > nodo.id_logro:
            nodo.derecha = self._insertar_recursivo(nodo.derecha, id_logro, titulo, descripcion, completado)
            
        return nodo

    # Recorrido RECURSIVO en InOrden (Izquierda, Raíz, Derecha) para listar los logros ordenados
    def obtener_inorden(self):
        resultado = []
        self._inorden_recursivo(self.raiz, resultado)
        return resultado

    def _inorden_recursivo(self, nodo, resultado):
        if nodo:
            self._inorden_recursivo(nodo.izquierda, resultado)
            resultado.append({
                "id": nodo.id_logro,
                "titulo": nodo.titulo,
                "descripcion": nodo.descripcion,
                "completado": nodo.completado
            })
            self._inorden_recursivo(nodo.derecha, resultado)

# --- Bloque de prueba y comunicación con C# ---
if __name__ == "__main__":
    arbol = ArbolLogrosBST()
    
    # Insertamos los logros base del sistema de PlayKids de forma jerárquica/BST
    arbol.insertar(10, "Primeros Pasos", "Completa tu primera lección de inglés", True)
    arbol.insertar(5, "Explorador de Colores", "Aprende los colores básicos", True)
    arbol.insertar(15, "Maestro del Vocabulario", "Supera las 50 palabras", False)
    arbol.insertar(2, "Super Oyente", "Completa un ejercicio de audio", False)
    arbol.insertar(8, "Gramática Infantil", "Usa verbos correctamente", False)

    # Devolvemos la estructura procesada en formato JSON para que C# la pueda leer limpiamente
    logros_ordenados = arbol.obtener_inorden()
    print(json.dumps(logros_ordenados, indent=4))