# API de Integração Bancária (Simulação)

Esta API simula operações comuns em integrações bancárias:
- Registro de títulos
- Baixa
- Cancelamento
- Consulta de status

## Stack
- ASP.NET Core
- Swagger
- Serviço em memória

## Como executar
```bash
dotnet run
```

## Endpoints
- POST `/api/titulo` – cria título
- PUT `/api/titulo/{id}/baixa` – baixa título
- PUT `/api/titulo/{id}/cancelar` – cancela título
- GET `/api/titulo/{id}` – busca título
- GET `/api/titulo` – lista todos