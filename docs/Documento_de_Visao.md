# Documento de visão

## ECommerce-D

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 01/06/2021 | **1.00** | Versão Inicial  | George Azevedo |

## 1. Objetivo do Projeto 
Este projeto tem objetivo de desenvolver um site que sirva de plataforma para leitores trocarem livros entre si sem a necessidade de transferências monetárias.
 
## 2. Descrição do problema 
| | |
|:-|:-|
| **_O problema_**    | é a inexistência de um serviço local atraente e prático que sirva para a troca de livros  |
| **_afetando_**      | leitores que procuram a oportunidade de doar um livro e ganhar outro                      |
| **_cujo impacto é_**| a necessidade de gastar dinheiro para uma compra ou ir em um local como um sebo/biblioteca sem a certeza da disponibilidade de um livro que lhe é de interesse                                    |
| **_uma boa solução seria_** | a criação de um sistema prático, funcional e interativo em que leitores possam achar livros de seus interesses com facilidade sem a necessidade de gastar dinheiro  |
| | |

## 3. Descrição dos usuários
| Nome | Descrição | Responsabilidades |
|:- |:- |:- |
| Moderador  | Administrador da plataforma | Filtrar o conteúdo postado no site em imagens/texto; Analisar comentários, reclamações e denúncias  |
| Visitante   | Usuário que visualiza o site; O visitante deve ter a possibilidade de obter informações acerca dos produtos postados, sem a necessidade de registrar suas informações cadastrais no site | O visitante deve poder consultar os produtos por várias opções de busca de forma a facilitar que ele encontre os produtos desejados; Caso deseje, poderá criar um registro de usuário com senha de forma a possibilitar o acesso a área de negociações, lista de desejos e estante |
| Leitor | Usuário cadastrado; O leitor, após realizar seu cadastro no site, poderá criar uma estante e realizar trocas | Após a realização a inclusão de dados cadastrais tais como login e senha o usuário passa a ser visto como cliente e poderá registrar solicitações de troca. As trocas poderão ser compostas por uma proporção de no máximo 5 livros para 1. O cliente deve ter acesso às seguintes funcionalidades no site: Alterar seus dados cadastrais, com excessão do email ou número de celular identificadores; Visualizar seu histórico de trocas e observar a situação das mesmss; Cancelar as trocas; Avaliar os outros leitores|

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
Esse projeto consiste em um site voltado para vendas de produtos que pretende funcionar de forma rápida e eficiente, disponibilizando um ambiente acessível a diversos tipos de usuários e possuindo um design confortável. Para tal, o site irá disponibilizar diferentes mecanismos de busca permitindo que o usuário encontre de forma eficiente o que ele precisa. Após a aquisição, o usuário poderá acompanhar o produto comprado, avaliar produtos da loja, comentar e marcar produtos como favoritos. 

Esse projeto consiste em um site voltado para a troca de livros que pretende funcionar de forma prática, atrativa e interativa, disponibilizando um ambiente acessível a todos os tipos de leitores e possuindo um design confortável. Para tal, o site irá fornecer mecanismos de busca, catalogação e negociação para que o usuário consiga fazer tudo que lhe for necessário quanto às trocas. Após uma negociação finalizada, o usuário poderá combinar um ponto de encontro com o outro usuário para que a troca seja efetuada num ambiente físico e, após essa troca, ambos deverão se avaliar levando em conta os produtos que receberam.

## 8.	Requisitos funcionais
| Código | Nome | Descrição |
|:---  |:--- |:--- |
| F01	| Adicionar, remover ou alterar produtos | O administrador tem à sua disponibilidade a função de adicionar, remover ou alterar produtos comercializados no site estabelecendo ainda seus preços de venda. 
| F02	| Adicionar, remover ou alterar grupos de produtos.	| O administrador tem à sua disponibilidade a função de adicionar, remover ou alterar grupos de produtos comercializados no site.
| F03	| Adicionar, remover ou alterar fabricante de produtos.	| O administrador tem à sua disponibilidade a função de adicionar, remover ou alterar fabricantes de produtos comercializados no site.
| F04	| Disponibilizar ou bloquear a apresentação do produto no site de venda	| O administrador tem à sua disponibilidade a função de liberar ou bloquear a apresentação de produtos a venda 
| F05	| Consultar pedidos realizados e não enviados.	| O administrador pode acessar os dados de vendas de produtos do site que foram realizados pelos clientes e que ainda não foram remetidos
| F06	| Registrar recebimento do pagamento do cliente	| O administrador registra no site a identificação do recebimento do pagamento realizado pelo cliente liberando o pedido para envio.
| F07	| Registrar o envio do pedido.	| O administrador informa no site a forma de envio do pedido ao cliente.
| F08	| Visualizar produtos	| O usuário visualiza os produtos disponíveis filtrando ou por grupos, fabricante ou através de um trecho do nome do produto
| F09	| Adicionar ou remover produtos à cesta de compras	| O usuário  pode escolher mais de um produto para realizar a compra e inserir em uma cesta de compras.
| F10	| Realizar o cadastro e login no site	| O usuário pode se cadastrar no site para poder comprar produtos e acessar outras diversas funcionalidades como avaliar e comentar os produtos.
| F11	| Realizar a compra de um produto	| Os clientes podem confirmar a compra dos produtos adicionados em sua cesta de compra gerando assim um pedido.
| F12	| Realizar o cancelamento de pedido solicitado	| Os clientes podem solicitar o cancelamento de um pedido realizado desde que ainda não tenha sido enviado.
| F13	| Verificar as compras realizadas	| Os clientes podem verificar seu histórico de compra na loja.
| F14	| Verificar o andamento do pedido	| Os clientes podem acompanhar o andamento da entrega dos pedidos realizados.
| F15	| Avaliar o Produto	| Os clientes podem avaliar os produtos realizando um comentário e atribuindo uma nota
| F16 	| Revisar dados cadastrais	| Os clientes podem alterar seus dados cadastrais permitindo assim que façam, por exemplo, alteração do endereço de entrega
| | | | 

## 9.	Requisitos não-funcionais
| Código | Nome | Descrição | Categoria | Classificação |
|:---  |:--- |:--- |:--- |:--- |
| NF01	| Design responsivo	| O site apresentará responsividade, deixando-o mais confortável para o usuário | Usabilidade	| obrigatório
| NF02	| Acesso somente com internet	| É necessário um acesso contínuo à Internet para poder acessar os dados do site e suas funcionalidades, como comprar produtos.	| Disponibilidade	| Obrigatório
| NF03	| Criptografia das informações sensíveis aos usuários	| Senhas do usuário devem ser gravadas de forma criptografada no banco de dados	| Segurança	| Obrigatório
| NF04	| Organização do conteúdo de forma objetiva	| O site apresentará o conteúdo de forma objetiva, de modo que o usuário encontre o desejado com facilidade.	| Usabilidade	| Obrigatório
| | | | 
