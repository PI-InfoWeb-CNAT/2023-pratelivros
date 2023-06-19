# Projeto pratelivros

## Especificação do caso de uso - Cadastrar livros

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |


### 1. Resumo 
Este caso de uso permite que leitor cadastre um livro no sistema.


### 2. Atores 
- Leitor

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O leitor ter se logado no sistema
- O leitor apertar no botão mais no cabeçalho do site

### 4.Pós-condições
Após a execução deste casos de uso, espera que o sistema:
- Guarde os dados do livro cadastrado e, portanto, permita a publicação de exemplares do livro

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor aperta no botão mais | --- |
| --- |2. O sistema redireciona o leitor para a página de cadastro | --- |
|3. O leitor insere os dados do livro a ser cadastrado | --- |
|--- |4. O sistema processa e guarda os dados cadastrados |
|5. O leitor é redirecionado para a página do livro que acabou de cadastrar | --- |


#### 5.2. Fluxo de excessão 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor aperta no botão mais | --- |
| --- |2. O sistema redireciona o leito para a página de cadastro | --- |
|3. O leitor insere os dados do livro a ser cadastrado | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro |

### 6. Prototipos de Interface
a. Página de cadastro de livro
![cadastro de livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/57df6ee0-5cac-42bb-b6a8-15f8b6fab83b)

b. Página de visualização dos detalhes do livro
![detalhes do livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/9b85d29a-28b6-4527-a857-a5514be31a39)


### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`
