# Post-Api
An Regular Api using Clean Architecture, CQRS and MediatR.

## Índice

- [Requisitos](#requisitos)
- [Instalação](#Instalação)
- [Uso](#uso)
- [Contribuindo](#contribuindo)
- [Licença](#licença)

## Requisitos
1. .Net 6
2. Docker Desktop (Windows)

## Instalação

Para utlizar este projeto você pode seguir alguns passos:

- Clonar o repositório.

- Abra um terminal na raiz do projeto e rode esse comando para inicializar o banco de dados:
  
```
docker-compose up
```

- Aplique a migration no banco de dados:
    - Abra o console de gerenciador de pacotes.
    - Rode o comando:
      
    ```
    update-database
    ```

- Usar o comando para rodar o projeto:
    - Se você estiver usando o Visual Studio aperte F5 no teclado.
    - Se você estiver usando linha de comando:

    ```
    dotnet run
    ```

## Uso
