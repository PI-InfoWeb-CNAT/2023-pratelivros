# Projeto pratelivros

## Especificação do caso de uso - Cadastrar livro

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 11/09/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |

### 1. Resumo 
Este caso de uso permite que um leitor visualize os detalhes de um livro cadastrado no sistema.

### 2. Atores 
- Leitor
- Moderador
- Visitante

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
|1. O usuário pesquisa por determinado livro na plataforma | --- |
| --- |2. O sistema redireciona o usuário para o resultado de sua pesquisa | --- |
|3. O usuário clica para acessar os detalhes de um livro | --- |
|--- |4. O sistema redireciona o usuário para a página de detalhes daquele livro, contendo as informações título, capa, data de publicação, autor, idioma, editora, gênero, edição, n° de páginas, ISBN, descrição e os usuários que possuem, sendo possível acessar as informações dos exemplares desses usuários |

#### 5.2. Fluxos alternativos

##### 5.2.1 Acessar detalhes pela prateleira de um usuário
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário acessa a prateleira de qualquer usuário da plataforma, podendo ser até dele mesmo | --- |
|--- |2. O sistema redireciona o usuário para a página de detalhes da prateleira, contendo as informações nome, data de última modificação, data de criação e os livros que a compõem |
|3. O usuário clica para acessar os detalhes de um livro | --- |
|--- |4. O sistema redireciona o usuário para a página de detalhes daquele livro, contendo as informações título, capa, data de publicação, autor, idioma, editora, gênero, edição, n° de páginas, ISBN, descrição e os usuários que possuem, sendo possível acessar as informações dos exemplares desses usuários |

##### 5.2.2 Acessar detalhes pela página inicial
|  Ator  | Sistema |
|:-------|:------- |
|1. O leitor ou o moderador acessa a página inicial do sistema, com as seções "Recomendados para você" e "Últimas adições" e clica para acessar os detalhes de um dos livros destas seções | --- |
|--- |2. O sistema redireciona o usuário para a página de detalhes daquele livro, contendo as informações título, capa, data de publicação, autor, idioma, editora, gênero, edição, n° de páginas, ISBN, descrição e os usuários que possuem, sendo possível acessar as informações dos exemplares desses usuários |

### 6. Protótipos de Interface
#### 6.1. Página de resultados da pesquisa
![pesquisa](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/9995d00a-4c25-4dfb-824a-d6944151c679)

#### 6.2. Página de visualização dos detalhes de um livro
![detalhes do livro](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/4d2a552a-4568-45b0-b34c-6e2f414c5524)

#### 6.3. Página de visualização dos detalhes de um livro com modal
![detalhes do exemplar](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/a775a486-65cb-48b3-a230-890ab67372da)

#### 6.4. Página de detalhes de prateleira
![prateleira](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/af60849f-3eb0-4acf-ac07-54bd810ce8f6)

#### 6.2. Página inicial do usuário logado
![pagina de leitor](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/84422577/770fa5fd-1819-4671-ac04-6cff696d28f6)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`
