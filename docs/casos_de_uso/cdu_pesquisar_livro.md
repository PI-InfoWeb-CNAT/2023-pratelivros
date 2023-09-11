# Projeto pratelivros

## Especificação do caso de uso - Pesquisar livro

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 11/09/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |

### 1. Resumo 
Este caso de uso permite que um leitor pesquise um livro cadastrado no sistema.

### 2. Atores 
- Leitor

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O leitor estar logado no sistema

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Não possui

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor acessa a barra de pesquisa no cabeçalho do site, digita a sua busca e aperta no ícone ou na tecla Enter | --- |
| --- |2. O sistema consulta no banco de dados resultados pelo termo digitado e redireciona o leitor para uma página contendo esses resultados | --- |

#### 5.2. Fluxo de excessão

##### 5.2.1 Pesquisa em branco
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor acessa a barra de pesquisa no cabeçalho do site, não digita a sua busca mas aperta no ícone ou na tecla Enter | --- |
|--- |2. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("Para fazer uma busca, digite algo na barra de pesquisa") |

##### 5.2.2 Pesquisa com mais de 50 caracteres
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor acessa a barra de pesquisa no cabeçalho do site, digita a sua busca em mais de 50 caracteres e aperta no ícone ou na tecla Enter | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("Não exceda 50 caracteres em sua busca") |

### 6. Protótipos de Interface
#### 6.1. Página resultados de busca
![pesquisa](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/8db77239-f3a8-4a91-a378-c86a84f9f289)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- Busca - Uma cadeia de caracteres alfanuméricos tamanho 50

