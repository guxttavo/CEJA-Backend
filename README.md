# 🎓 Sistema Escolar - Angular + .NET

Sistema de gestão escolar desenvolvido com **DDD (Domain-Driven Design)** e **Repository Pattern**, utilizando **Angular** no front-end e **.NET** no back-end.

---

## 📌 Índice

- [📖 Sobre o Projeto](#-sobre-o-projeto)
- [🛠 Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [🧱 Arquitetura do Projeto](#-arquitetura-do-projeto)
- [▶️ Como Rodar o Projeto](#️-como-rodar-o-projeto)
- [🚧 Funcionalidades Futuras](#-funcionalidades-futuras)

---

## 📖 Sobre o Projeto

Este sistema foi projetado para uso interno em escolas, com o objetivo de **automatizar e facilitar processos administrativos**, promovendo mais organização e eficiência no gerenciamento escolar.

Principais funcionalidades:

- Cadastro e gerenciamento de **alunos** e **professores**
- Organização de **disciplinas**
- **Geração de certificados personalizados**
- **Gestão de turmas** e estrutura pedagógica

Além das funcionalidades práticas, o projeto é um estudo aplicado de boas práticas de desenvolvimento, com:

- **DDD**, para centralizar a lógica de negócio
- **Repository Pattern**, para abstração do acesso a dados

---

## 🛠 Tecnologias Utilizadas

### Backend (.NET)
- ASP.NET Core
- Entity Framework Core
- AutoMapper
- SQLite

### Frontend (Angular)
- Angular
- TypeScript
- RxJS

### DevOps
- Docker

---

## 🧱 Arquitetura do Projeto

### 🔹 Backend

Camadas organizadas conforme a arquitetura limpa:

- **Domain**: Entidades e regras de negócio
- **Application**: Casos de uso
- **Infrastructure**: Acesso ao banco de dados
- **API**: Controllers e endpoints REST

### 🔹 Frontend

Estruturado por módulos e componentes, com serviços para integração com a API e interfaces para tipagem dos dados.

---

## ▶️ Como Rodar o Projeto

### Backend (.NET)
```bash
cd backend
dotnet build
dotnet run
