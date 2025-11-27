[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE.md)
![.NET](https://img.shields.io/badge/.NET-10+-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/status-active-brightgreen)

<h1 align="center"><img src="https://raw.githubusercontent.com/BrasilAPI/BrasilAPI/master/public/brasilapi-logo-small.png">

<div align="center">
  <p>
    <strong>Vamos transformar o Brasil em uma API?</strong>
  </p>
</div>

# Atenção
Este é um SDK/Client .Net para <a href="https://github.com/BrasilAPI/BrasilAPI" target="_blank">BrasilAPI</a>!

# IntegracaoBrasilApi

SDK/Client .NET para consumir a [BrasilAPI](https://brasilapi.com.br) — facilitando a interação com os serviços públicos de dados do Brasil.

## ✨ Visão Geral

Este projeto fornece uma biblioteca em C#/.NET que simplifica o consumo das APIs disponíveis na BrasilAPI. Com ele, você pode consultar, de forma fácil e organizada, dados como CEP, CNPJ, dados de municípios, e outros endpoints disponibilizados pela BrasilAPI.

### Principais funcionalidades

- 📦 Chamadas para diversos endpoints da BrasilAPI  
- ✅ Serialização e mapeamento dos dados para objetos C# fortemente tipados  
- 🚀 Facilidade de uso em projetos .NET (console, web, APIs, desktop, etc)  
- 🔄 Integração simples: basta referenciar o pacote / projeto e usar os métodos fornecidos  

## 🛠️ Tecnologias utilizadas

- C# / .NET  
- HttpClient (ou similar) para requisições HTTP  
- JSON (serialização/desserialização)  
- [BrasilAPI](https://brasilapi.com.br) — a API pública de dados  

## ✅ Pré-requisitos

- .NET 10.0
- AutoMapper 15.1.0
- Swashbuckle (Swagger) 10.0.1

## 🚀 Como instalar e usar

1. Clone este repositório  
   ```bash
   git clone https://github.com/GeanGilberto01/IntegracaoBrasilApi.git

2. Abra o projeto na sua IDE (Visual Studio, VS Code, Rider etc)

3. Compile a solução (.sln)

4. Referencie o projeto ou adicione como dependência no seu outro projeto .NET

## 🎯 Quando usar este SDK

Use este SDK quando você estiver desenvolvendo aplicações .NET que precisam consultar dados públicos do Brasil disponíveis na BrasilAPI — como CEP, dados de empresas, dados de municípios, e outros — sem se preocupar com os detalhes de requisição HTTP ou parsing de JSON.

## 🤝 Como contribuir

1. Crie uma branch para sua feature ou correção.
2. Garanta que o código segue o padrão do projeto.
3. Abra um pull request descritivo.

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE.md](LICENSE.md) para mais detalhes.

## 📢 Observações

Este repositório não é afiliado oficialmente à BrasilAPI; trata-se apenas de uma integração para facilitar seu uso em projetos .NET.
