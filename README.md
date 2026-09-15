# Manual Técnico y Guía del Sistema: Laboratorio DSV III

Este proyecto es una aplicación de escritorio desarrollada en **Visual Basic .NET** sobre la plataforma **.NET 10 (Windows Forms)**. Su objetivo es proporcionar una interfaz fluida e intuitiva para administrar colecciones dinámicas de datos utilizando controles `ListBox` y `ComboBox`, vinculados en tiempo real a una vista gráfica interactiva (`PictureBox`).

---

## 💡 ¿Qué hace este programa?

La aplicación permite gestionar listas de elementos (como continentes, países o recursos corporativos) y asociarlos automáticamente con archivos visuales almacenados en el disco local.

### Funcionalidades clave:
1. **Visualización dinámica de imágenes**: Al hacer clic en un elemento de la lista principal (`ListBox`), el sistema busca automáticamente la imagen correspondiente en la carpeta de recursos activos y la renderiza en el `PictureBox`.
2. **Gráficos de respaldo dinámicos (Fallback GDI+)**: Si un elemento agregado no cuenta con una imagen física en la carpeta, la aplicación genera al instante un recurso visual vectorial elegante con el nombre del elemento, ajustando dinámicamente el tamaño del texto para que no se desborde.
3. **Transferencia bidireccional de datos**: Permite mover elementos entre la lista vertical (`ListBox`) y el menú desplegable (`ComboBox`) con un solo clic, manteniendo la sincronización y evitando registros duplicados.
4. **Selección flexible de directorio de recursos**: Se puede cambiar en cualquier momento la carpeta desde la que se leen las imágenes mediante un selector de carpetas nativo (`FolderBrowserDialog`).
5. **Navegación entre formularios**: Incluye un menú principal (`Menu.vb`) que demuestra la navegación multipartes dentro de la arquitectura Windows Forms.

---

## 🛠️ Auditoría de Código y Mejoras Implementadas

Durante el proceso de auditoría y refactorización, se identificaron y resolvieron diversos aspectos clave para mejorar la estabilidad, seguridad y experiencia del usuario:

### 1. Gestión de memoria y renderizado GDI+
* **Problema anterior**: Leer imágenes directamente desde el disco mediante `Image.FromFile` o mantener flujos abiertos dejaba los archivos bloqueados en el sistema operativo, impidiendo editarlos o borrarlos mientras la aplicación estaba en ejecución. Además, cerrar prematuramente un `MemoryStream` podía causar errores genéricos de GDI+ al repintar la ventana.
* **Solución aplicada**: Se implementó una técnica de lectura con `FileStream` en modo `FileShare.Read`, cargando la secuencia completa en un `MemoryStream` y creando un clon independiente de la imagen (`DirectCast(imagenTemp.Clone(), Image)`). Esto permite cerrar y liberar los recursos de lectura de inmediato sin bloquear el archivo físico ni desestabilizar el canvas.

### 2. Búsqueda insensible a mayúsculas/minúsculas
* **Problema anterior**: Las búsquedas de imágenes requerían nombres o extensiones rígidas (`.png`, `.jpg`).
* **Solución aplicada**: Se añadió un algoritmo de correspondencia flexible que inspecciona la carpeta de recursos e ignora las diferencias de mayúsculas/minúsculas tanto en el nombre como en la extensión (`.PNG`, `.png`, `.jpg`, `.JPEG`, etc.).

### 3. Saneamiento de entradas y prevención de excepciones
* **Problema anterior**: Si un usuario ingresaba caracteres especiales no permitidos en nombres de archivos (como `?`, `*`, `/`, `\`), la aplicación podía arrojar excepciones no controladas.
* **Solución aplicada**: Se incorporó validación mediante `Path.GetInvalidFileNameChars()`. Si un nombre contiene caracteres no válidos, el programa lo detecta pacíficamente y genera el gráfico de respaldo sin interrumpir el flujo del usuario.

### 4. Ajuste tipográfico inteligente en el gráfico de respaldo
* **Problema anterior**: Los nombres muy largos en elementos generados por software podían desbordarse fuera de la tarjeta visual.
* **Solución aplicada**: El método `GenerarImagenRespaldo` evalúa la longitud de la cadena y ajusta de forma proporcional el tamaño de la fuente (`Segoe UI`), garantizando un acabado estético en todo momento.

---

## 📂 Estructura del Código Fuente

```text
Laboratorio---ISA/
│
├── Lab - ISA/
│   ├── Lab - ISA.slnx                   # Solución principal de Visual Studio
│   └── Lab - ISA/
│       ├── Form1.vb                     # Lógica principal de gestión de controles y recursos
│       ├── Form1.Designer.vb            # Estructura visual y componentes del formulario principal
│       ├── Menu.vb                      # Formulario secundario (Menú de navegación)
│       ├── ApplicationEvents.vb         # Eventos globales de la aplicación
│       ├── Lab - ISA.vbproj             # Configuración del proyecto .NET 10
│       └── Imagenes/                    # Carpeta de recursos gráficos predeterminados
│           ├── AFRICA.png
│           ├── AMERICA.png
│           ├── ANTARTIDA.png
│           ├── ASIA.png
│           ├── EUROPA.png
│           └── OCEANIA.png
└── README.md                            # Documentación técnica
```

---

## 🖥️ Guía de Uso de la Interfaz

1. **Selección de Elementos**:
   - Haz clic sobre cualquier continente en la lista `ListBox1` para ver su imagen o su gráfico representativo.

2. **Agregar un Nuevo Elemento**:
   - Escribe el nombre en el cuadro de texto.
   - Presiona `Enter` o haz clic en **Agregar a Lista** o **Agregar a Combo**.
   - El sistema validará que el texto no esté vacío ni duplicado.

3. **Transferir entre Controles**:
   - Selecciona un ítem en el `ComboBox1` y presiona **Recibir en ListBox desde Combo** para pasarlo a la lista principal.
   - Selecciona un ítem en el `ListBox1` y presiona **Pasar a Combo** para moverlo al menú desplegable.

4. **Cambiar Carpeta de Imágenes**:
   - Presiona el botón **📁 Carpeta de Recursos...** en el encabezado superior para vincular una nueva carpeta de imágenes desde tu equipo.

5. **Restaurar Datos**:
   - Haz clic en **🔄 Reiniciar Lista** para volver a la configuración inicial de continentes predeterminados.

---

## ⚙️ Compilación y Ejecución

### Requisitos previos:
* SDK de .NET 10.0 o superior instalada.
* Visual Studio 2022 / VS Code con extensión C#/VB.NET (opcional).

### Ejecutar desde la consola de comandos:

```bash
# Navegar al directorio del proyecto
cd "Lab - ISA/Lab - ISA"

# Compilar la aplicación
dotnet build

# Ejecutar el proyecto
dotnet run
```

---

*Desarrollado como módulo práctico de arquitectura de interfaces de usuario y gestión limpia de recursos gráficos en Windows Forms.*
