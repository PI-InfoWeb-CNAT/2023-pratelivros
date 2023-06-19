# Projeto pratelivros

## Especificação do caso de uso - Cadastrar livro

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |
| 19/06/2023 | **2.00** | Correção ortográfica  | Lucas de LIMA |

### 1. Resumo 
Este caso de uso permite que um leitor cadastre um livro no sistema.

### 2. Atores 
- Leitor

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O leitor estar logado no sistema
- O leitor apertar no botão "+" e em seguida "Cadastrar livro" no cabeçalho do site

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Armazene os dados do livro cadastrado e, portanto, permita a publicação de exemplares do livro

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor realiza o login na plataforma | --- |
|2. O leitor aperta no botão "+" e em seguida "Cadastrar livro" | --- |
| --- |3. O sistema redireciona o leitor para a página de cadastro de livro | --- |
|4. O leitor insere os dados do livro a ser cadastrado | --- |
|--- |5. O sistema valida e armazena os dados cadastrados |
|6. O leitor é redirecionado para a página do livro que acabou de cadastrar | --- |

#### 5.2. Fluxo de excessão 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor realiza o login na plataforma | --- |
|2. O leitor aperta no botão "+" e em seguida "Cadastrar livro" | --- |
| --- |3. O sistema redireciona o leito para a página de cadastro de livro | --- |
|4. O leitor insere os dados do livro a ser cadastrado | --- |
|--- |5. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro |

### 6. Protótipos de Interface
#### 6.1. Página de cadastro de um livro
![cadastro de livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/3c725794-11be-41c9-838a-6481d6221992)

#### 6.2. Página de visualização dos detalhes de um livro
![detalhes do livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/9b85d29a-28b6-4527-a857-a5514be31a39)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`
