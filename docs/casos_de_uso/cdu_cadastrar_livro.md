# Projeto pratelivros

## Especificação do caso de uso - Cadastrar livro

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |
| 19/06/2023 | **2.00** | Correção ortográfica  | Lucas de LIMA |
| 25/06/2023 | **3.00** |  Correção e criação dos tópicos 8 e 9  | Lucas de LIMA |

### 1. Resumo 
Este caso de uso permite que um leitor cadastre um livro no sistema.

### 2. Atores 
- Leitor

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O leitor estar logado no sistema

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Armazene os dados do livro cadastrado e, portanto, permita a publicação de exemplares do livro

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor aperta no botão "+" e em seguida "Cadastrar livro" | --- |
| --- |2. O sistema redireciona o leitor para a página de cadastro de livro | --- |
|3. O leitor insere os dados do livro a ser cadastrado (Capa, Título, Autor, Descrição, Gênero, Data de Publicação, ISBN, Editora, Edição, N° de Páginas e Idioma) | --- |
|--- |4. O sistema valida e armazena os dados cadastrados |
|5. O leitor é redirecionado para a página do livro que acabou de cadastrar | --- |

#### 5.2. Fluxo de excessão

##### 5.2.1 Capa em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere a Capa do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Capa' é obrigatório") |

##### 5.2.2 Arquivo de Capa muito grande
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor insere um arquivo muito grande no campo 'Capa' e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O tamanho máximo de arquivo é 2 MB") |

##### 5.2.3 Título em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o Título do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Título' é obrigatório") |

##### 5.2.4 Autor em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o Autor do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Autor' é obrigatório") |

##### 5.2.5 Descrição em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere a Descrição do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Descrição' é obrigatório") |

##### 5.2.6 Gênero em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o Gênero do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Gênero' é obrigatório") |

##### 5.2.7 Data de Publicação em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere a Data de Publicação do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Data de Publicação' é obrigatório") |

##### 5.2.8 ISBN em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o ISBN do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'ISBN' é obrigatório") |

##### 5.2.9 Editora em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere a Editora do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Editora' é obrigatório") |

##### 5.2.10 Edição em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere a Edição do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Edição' é obrigatório") |

##### 5.2.11 N° de Páginas em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o N° de Páginas do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'N° de Páginas' é obrigatório") |

##### 5.2.12 Idioma em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O leitor não insere o Idioma do livro e clica em "Cadastrar livro" | --- |
|--- |4. O sistema não valida os dados inseridos pelo leitor e exibe uma mensagem de erro ("O campo 'Idioma' é obrigatório") |

### 6. Protótipos de Interface
#### 6.1. Página de cadastro de um livro
![cadastro de livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/3c725794-11be-41c9-838a-6481d6221992)

#### 6.2. Página de visualização dos detalhes de um livro
![detalhes do livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/9b85d29a-28b6-4527-a857-a5514be31a39)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- Capa - Arquivo de imagem (PNG, JPG, JPEG, SVG, WEBP)
- Título - Uma cadeia de caracteres alfabéticos tamanho 50
- Autor - Uma cadeia de caracteres alfabéticos tamanho 30
- Descrição - Uma cadeia de caracteres alfanuméricos tamanho 1000
- Gênero - Uma cadeia de caracteres alfabéticos tamanho 30
- Data de Publicação - Data do calendário em modelo DD/MM/AAAA
- ISBN - Uma cadeia de 13 caracteres numéricos 
- Editora - Uma cadeia de caracteres alfabéticos tamanho 30
- Edição - Uma cadeia de caracteres numéricos tamanho 2
- N° de Páginas - Uma cadeia de caracteres numéricos tamanho 4
- Idioma - Uma cadeia de caracteres alfabéticos tamanho 15

### 9. Regras de negócio
- Capa - Tamanho máximo de 2 MB
