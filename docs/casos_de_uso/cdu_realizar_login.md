# Projeto pratelivros

## Especificação do caso de uso - Realizar login

### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Primeira versão | Lucas de LIMA |
| 23/06/2023 | **2.00** | Criação dos tópicos 8 e 9 | Gabriel FERREIRA |

### 1. Resumo
Este caso de uso permite que um usuário realize login no sistema.

### 2. Atores
- Leitor
- Moderador

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O usuário possuir uma conta cadastrada na plataforma

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Autentique os dados do usuário e, portanto, o permita utilizar as funcionalidades da plataforma

### 5. Fluxos de evento

#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aperta no botão "Login" | --- |
| --- |2. O sistema redireciona o usuário para a página de login | --- |
|3. O usuário insere os seus dados (E-mail e Senha) e clica em "Login" | --- |
|--- |4. O sistema valida os dados inseridos |
|5. O usuário, já autenticado, é redirecionado para a página inicial | --- |

#### 5.2. Fluxo de excessão
##### 5.2.1 E-mail em branco
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aperta no botão "Login" | --- |
| --- |2. O sistema redireciona o usuário para a página de login | --- |
|3. O usuário não insere seu E-mail e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'E-mail' é obrigatório") |

##### 5.2.2 Senha em branco
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aperta no botão "Login" | --- |
| --- |2. O sistema redireciona o usuário para a página de login | --- |
|3. O usuário não insere sua Senha e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'Senha' é obrigatório") |

##### 5.2.3 E-mail incorreto
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aperta no botão "Login" | --- |
| --- |2. O sistema redireciona o usuário para a página de login | --- |
|3. O usuário insere seu E-mail incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Não foi possível validar essas credenciais, altere os dados e tente novamente") |

##### 5.2.3 Senha incorreta
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aperta no botão "Login" | --- |
| --- |2. O sistema redireciona o usuário para a página de login | --- |
|3. O usuário insere sua Senha incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Não foi possível validar essas credenciais, altere os dados e tente novamente") |

### 6. Protótipos de Interface
#### 6.1. Página inicial do sistema
![pagina de visitante](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/3ca8d765-60e6-4381-8a62-0d156fe3361d)

#### 6.2. Página de login
![pagina de login](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/83a6e044-3297-46fa-9c2f-619401cd2b8f)

#### 6.3. Página inicial de usuário autenticado
![pagina inicial autenticado](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/c971e836-28e0-43a0-9abf-546a1d15ce08)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- E-mail: Uma cadeia de caracteres 
- Senha: Uma cadeia de caracteres tamanho 15

### 9. Regras de negócio
- E-mail: Não pode possuir caracteres especiais além do ponto e deve conter, respectivamente, um conjunto de caracteres alfanuméricos, um arroba, outro conjunto de letras e um ou mais domínios de topo
- Senha: Deve possuir no mínimo: oito caracteres alfanuméricos, sendo incluso um número, um caractere especial, uma letra maiúscula e uma minúscula
