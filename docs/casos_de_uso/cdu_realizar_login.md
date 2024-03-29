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
|3. O usuário não insere seu E-mail e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'E-mail' é obrigatório") |

##### 5.2.2 Senha em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário não insere sua Senha e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'Senha' é obrigatório") |

##### 5.2.3 E-mail incorreto
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere seu E-mail incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Este não é um endereço de E-mail válido. Altere os dados e tente novamente") |

##### 5.2.4 Senha incorreta
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere sua Senha incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Senha incorreta. Altere os dados e tente novamente") |

### 6. Protótipos de Interface
#### 6.1. Página inicial do sistema
![pagina de visitante](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/099d93f4-3667-4801-8028-bb24f995b4eb)

#### 6.2. Página de login
![login](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/6ca18258-afe1-4b4d-b5e6-cc6b6317f6f6)

#### 6.3. Página inicial de usuário autenticado
![pagina de leitor](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/d870a170-6ded-4ef9-a853-0bd1de8ddeb9)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- E-mail - Uma cadeia de caracteres alfanuméricos tamanho 30
- Senha - Uma cadeia de caracteres alfanuméricos tamanho 20

### 9. Regras de negócio
- E-mail - Um conjunto de caracteres (com exceção dos caracteres especiais, sendo permitido apenas o ponto) seguidos, respectivamente, por um arroba, outro conjunto de letras e um ou mais domínios de topo
- Senha - Mínimo de 8 caracteres; pelo menos uma letra maiúscula e minúscula; um número; um caractere especial
