# VideoGames_CRUD

## Descrição

O **VideoGames_CRUD** é uma aplicação simples de gerenciamento de videogames que permite criar, ler, atualizar e deletar (CRUD) informações de jogos. Esta aplicação foi desenvolvida utilizando tecnologias modernas e segue as melhores práticas de desenvolvimento de software.

## Funcionalidades

- **Adicionar Jogo**: Permite adicionar novos jogos ao banco de dados.
- **Visualizar Jogos**: Exibe a lista completa de jogos cadastrados.
- **Atualizar Jogo**: Permite editar as informações de um jogo existente.
- **Excluir Jogo**: Permite remover jogos do banco de dados.

## Tecnologias Utilizadas

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: Node.js, Express
- **Banco de Dados**: MongoDB
- **Outros**: Mongoose (para modelagem de dados), EJS (para renderização de templates)

## Requisitos

Para executar este projeto, você precisará ter instalado em sua máquina:

- Node.js (versão 14 ou superior)
- MongoDB

## Instalação

Siga os passos abaixo para configurar e executar o projeto localmente:

1. Clone o repositório:
    ```bash
    git clone https://github.com/MigueLLima1/VideoGames_CRUD.git
    ```
   
2. Navegue até o diretório do projeto:
    ```bash
    cd VideoGames_CRUD
    ```

3. Instale as dependências:
    ```bash
    npm install
    ```

4. Configure o banco de dados MongoDB:

    - Certifique-se de que o MongoDB está em execução.
    - Você pode modificar a string de conexão do MongoDB no arquivo `config/database.js` se necessário.

5. Execute a aplicação:
    ```bash
    npm start
    ```

6. Abra o navegador e acesse:
    ```
    http://localhost:3000
    ```

## Estrutura do Projeto

- **/public**: Contém os arquivos estáticos (CSS, JavaScript, imagens).
- **/views**: Contém os arquivos EJS para renderização das páginas.
- **/routes**: Contém as definições das rotas da aplicação.
- **/models**: Contém os modelos Mongoose para o MongoDB.
- **/controllers**: Contém a lógica de controle da aplicação.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença

Este projeto é licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
