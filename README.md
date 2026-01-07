# VitaForge Web (Blazor WebAssembly)

**VitaForge** es una aplicación web diseñada para generar planes de alimentación personalizados basados en tus objetivos físicos, medidas corporales y nivel de actividad. Esta versión es una migración directa de la aplicación Android original a la web moderna utilizando **Blazor WebAssembly** y **Firebase**.

## 🚀 Características

- **Generación de Menús Inteligente**: Algoritmo matemático que calcula tus necesidades calóricas (RMR) y distribuye macronutrientes (proteínas, grasas, carbohidratos) para crear menús equilibrados.
- **Perfiles Personalizados**: Guarda tu peso, altura, edad, sexo y objetivos (Perder peso, Mantener, Ganar músculo).
- **Autenticación Segura**: Sistema de registro e inicio de sesión con correo electrónico mediante Firebase Auth.
- **Persistencia en la Nube**: Tus datos se sincronizan automáticamente con Firebase Firestore, accesibles desde cualquier navegador.
- **Diseño Responsivo**: Interfaz limpia y adaptable a móviles y escritorio.

## 🛠️ Tecnologías

- **Frontend**: .NET 9, Blazor WebAssembly.
- **Backend (BaaS)**: Google Firebase (Authentication & Firestore).
- **Lenguaje**: C# (Lógica del dominio y UI), JavaScript (Interop con Firebase SDK).
- **Estilos**: Bootstrap 5.

## 📋 Requisitos Previos

- [.NET 9 SDK](https://dotnet.microsoft.com/download) instalado.
- Cuenta de Google para acceder a Firebase Console (si deseas clonar y conectar tu propia base de datos).

## ⚙️ Configuración e Instalación

1.  **Clonar el repositorio**
    ```bash
    git clone https://github.com/tu-usuario/VitaForgeWeb.git
    cd VitaForgeWeb
    ```

2.  **Configurar Firebase**
    El proyecto ya incluye una configuración (`wwwroot/js/firebaseInterop.js`). Si deseas usar tu propio proyecto:
    - Crea un proyecto en [Firebase Console](https://console.firebase.google.com/).
    - Habilita **Authentication** (Proveedor: Email/Password).
    - Crea una **Firestore Database**.
    - Copia tu configuración web y reemplaza el objeto `firebaseConfig` en `wwwroot/js/firebaseInterop.js`.

3.  **Ejecutar la aplicación**
    ```bash
    dotnet run
    ```
    La aplicación estará disponible en `http://localhost:5200`.

## 📂 Estructura del Proyecto

- `Pages/`: Vistas de la aplicación (`Home`, `DatosUsuario`, `Menu`).
- `Models/`: Lógica de negocio pura (`Alimento.cs` con el algoritmo de dieta, `Usuario.cs`).
- `Services/`: Servicios de comunicación (`FirebaseService.cs`).
- `wwwroot/js/`: Código JavaScript de interop (`firebaseInterop.js`).

## 🤝 Contribución

¡Las contribuciones son bienvenidas! Si encuentras un error o quieres mejorar el algoritmo de dieta, no dudes en abrir un Pull Request.

---
*Basado en el proyecto original de Android [VitaForge](https://github.com/franjsantana/VitaForge)*.
