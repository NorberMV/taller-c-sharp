# taller-c-sharp
Primer taller de ejercicios en C#.


- [taller-c-sharp](#taller-c-sharp)
- [Como instalar el dev environment `(macOS)`?](#como-instalar-el-dev-environment-(macOS))
- [Como correr cada programa?](#como-correr-cada-programa)

# taller-c-sharp
Primer taller de lógica de programación en C#.

# Como instalar el dev environment `(macOS)`?

Navegar a https://dotnet.microsoft.com/en-us/download y descargar el installer standalone para macOS .NET 7.NET SDK Arm64 (Apple Silicon), 
luego correr el siguiente comando en la terminal para confirmar que quedó instalado:
```
$ dotnet --version
7.0.400
```

# Como correr cada programa?

- Este repositorio tiene la siguiente estructura de folders:
```
ejercicios
├── exercise_1
│   ├── Program.cs
│   ├── bin
│   ├── exercise_1.csproj
│   └── obj
├── exercise_2
│   ├── Program.cs
│   ├── bin
│   ├── exercise_2.csproj
│   └── obj
.
.
```
- Para correr un ejercicio en especifico se debe navegar hasta el root folder de cada ejercicio 'exercise_(numero-de-ejercicio)'
- Luego correr el siguiente comando, ejemplo:
```
# ./ejercicios/exercise_1

$ dotnet run
```


