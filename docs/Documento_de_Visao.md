# Documento de visão

## ECommerce-D

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 01/06/2021 | **1.00** | Versão Inicial  | George Azevedo |

## 1. Objetivo do Projeto 
Este projeto tem o objetivo de desenvolver um site que sirva de plataforma para leitores trocarem livros entre si sem a necessidade de transferências monetárias.
 
## 2. Descrição do problema 
| | |
|:-|:-|
| **_O problema_**    | é a inexistência de um serviço local atraente e prático que sirva para a troca de livros  |
| **_afetando_**      | leitores que procuram a oportunidade de doar um livro e receber outro                      |
| **_cujo impacto é_**| a necessidade de gastar dinheiro em uma compra ou ir a um local como um sebo/biblioteca sem a certeza da disponibilidade de um livro que lhe é de interesse                                    |
| **_uma boa solução seria_** | a criação de um sistema prático, funcional e interativo em que leitores possam achar livros de seus interesses com facilidade sem a necessidade de gastar dinheiro  |
| | |

## 3. Descrição dos usuários
| Nome | Descrição | Responsabilidades |
|:- |:- |:- |
| Moderador  | Administrador da plataforma | Filtrar o conteúdo postado no site em imagens/texto; Analisar comentários, reclamações e denúncias  |
| Visitante   | Usuário que visualiza o site; O visitante deve ter a possibilidade de obter informações acerca dos produtos postados, sem a necessidade de registrar suas informações cadastrais no site | O visitante deve poder consultar os produtos por várias opções de busca de forma a facilitar que ele encontre os produtos desejados; Caso deseje, poderá criar um registro de usuário com senha de forma a possibilitar o acesso a área de negociações, lista de desejos e estante |
| Leitor | Usuário cadastrado; O leitor, após realizar seu cadastro no site, poderá criar uma estante e realizar trocas | Após a realização da inclusão de dados cadastrais tais como login e senha o usuário passa a ser visto como cliente e poderá registrar solicitações de troca. As trocas poderão ser compostas por uma proporção de no máximo 5 livros para 1. O cliente deve ter acesso às seguintes funcionalidades no site: Alterar seus dados cadastrais, com excessão do email ou número de celular identificadores; Visualizar seu histórico de trocas e observar a situação das mesmas; Cancelar as trocas; Avaliar os outros leitores|

## 4. Descrição do ambiente dos usuários 
O comércio eletrônico tem dois tipos de usuários. O tipo administrador representa o moderador da plataforma e o tipo Cliente que representa o leitor, seja ele anônimo ou já cadastrado. 

O administrador acessará o site de qualquer ambiente que esteja para fazer a filtragem de possíveis contas ou postagens que fujam das diretrizes da plataforma.

O usuário cliente irá acessar o site utilizando  um computador ou celular e realizará a visualização dos livros disponíveis para troca e realizará uma proposta, caso deseje. Neste caso também não há muitas restrições quanto ao ambiente pois ele poderá fazer as solicitações de qualquer local que tenha conexão com internet.


## 5. Principais necessidades dos usuários
Considerando o pronto de vista do moderador, administrador do site, sua principal necessidade é cultivar um ambiente saudável e convidativo que estimule os leitores a utilizarem o sistema de trocas. 

Considerando o pronto de vista do cliente, ele deseja ter acesso a um site com interface amigável que permita obter informações sobre os livros postados e, caso identifique que estes o interessem, ele possa montar sua negociação visando confirmar a aquisição. Outra necessidade para o cliente seria a de um ambiente agradável para postar seus próprios livros que já não possua tanto interesse para manter.

## 6. Alternativas concorrentes

São alternativas de concorrentes diretos o Livralivro, o Skoob e o Bookcrossing. Todos os três contem sistemas para a catalogação e troca de livros entre os usuário.
Já outras aplicações que também podem ser usadas para o mesmo propósito são o Instagram e o Mercado Livro, por mais que ambos não possuam propostas minimamente relacionadas a literatura ou trocas.

## 7.	Visão geral do produto 

Esse projeto consiste em um site voltado para a troca de livros que pretende funcionar de forma prática, atrativa e interativa, disponibilizando um ambiente acessível a todos os tipos de leitores e possuindo um design confortável. Para tal, o site irá fornecer mecanismos de busca, catalogação e negociação para que o usuário consiga fazer tudo que lhe for necessário quanto às trocas. Após uma negociação finalizada, o usuário poderá combinar um ponto de encontro com o outro usuário para que a troca seja efetuada num ambiente físico e, após essa troca, ambos deverão se avaliar levando em conta os produtos que receberam.

## 8.	Requisitos funcionais
| Código | Nome | Descrição |
|:---  |:--- |:--- |
| F01	| Remover livros publicados. | O moderador tem à sua disponibilidade a função de remover livros já publicados por leitores no site. 
| F02	| Banir contas cadastradas.	| O moderador tem à sua disponibilidade a função de banir contas já cadastradas por visitantes no site.
| F03	| Visualizar os livros já publicados.	| O visitante pode visualizar as informações de cada livros já publicado por um leitor.
| F04	| Realizar cadastro e login na plataforma.	| O visitante pode se cadastrar usando seus dados para conseguir acesso às funcionalidades de um leitor.
| F05	| Publicar livros disponíveis para troca.	| O leitor pode publicar no site um livro que possua fisicamente, descrevendo sua condição e suas informações com texto e imagens.
| F06	| Montar, alterar e remover estantes para o perfil.	| O leitor pode montar uma estante, alterar suas informações (sejam essas informações da estante em si ou os livros que a compõem) e também pode deletar uma estante de seu perfil.
| F07	| Abrir e receber solicitações de trocas.	| O leitor pode abrir uma solicitação de troca para cada livro publicado no site que não tenha sido publicado por si mesmo. Também pode receber solicitações de outros leitores na plataforma para os livros que tenha publicado.
| F08	| Realizar e receber propostas em trocas já iniciadas.	| Em cada troca iniciada, ambos os leitores podem criar ou receber propostas diferentes da que tenha sido feita inicialmente, até chegar em uma que seja aceita por ambos.
| F09	| Realizar cancelamento de uma troca.	| O leitor pode cancelar uma troca por completo, deixando o outro leitor sem a possibilidade de criar novas propostas.
| F10	| Visualizar seu histórico de trocas.	| O leitor pode acessar informações sobre suas trocas já finalizadas.
| F11	| Conversar no chat de cada negociação.	| Ambos os leitores de uma troca podem conversar no chat desta mesma troca.
| F12	| Avaliar outros leitores.	| Após uma troca finalizada, o leitor pode fazer a avaliação do outro leitor que tenha trocado seu(s) livro(s).
| F13 	| Revisar dados cadastrais	| O leitor pode alterar seus dados cadastrais, com exceção do dado que o identifique, sendo esse o email ou o celular.
| | | | 

## 9.	Requisitos não-funcionais
| Código | Nome | Descrição | Categoria | Classificação |
|:---  |:--- |:--- |:--- |:--- |
| NF01	| Design responsivo	| O site apresentará responsividade, deixando-o mais confortável para o usuário | Usabilidade	| obrigatório
| NF02	| Acesso somente com internet	| É necessário um acesso contínuo à Internet para poder acessar os dados do site e suas funcionalidades, como trocar produtos.	| Disponibilidade	| Obrigatório
| NF03	| Criptografia das informações sensíveis aos usuários	| Senhas do usuário devem ser gravadas de forma criptografada no banco de dados	| Segurança	| Obrigatório
| NF04	| Organização do conteúdo de forma objetiva	| O site apresentará o conteúdo de forma objetiva, de modo que o usuário encontre o desejado com facilidade.	| Usabilidade	| Obrigatório
| | | | 
