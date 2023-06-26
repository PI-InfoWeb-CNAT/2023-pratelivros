# Projeto pratelivros

## Especificação do caso de uso - Realizar cadastro

### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | *1.00* | Primeira versão | Lucas de LIMA |
| 24/06/2023 | *2.00* | Correção e criação dos tópicos 8 e 9 | Lucas de LIMA |

### 1. Resumo
Este caso de uso permite que um visitante se cadastre no sistema.

### 2. Atores
- Visitante

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- Não possui

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Armazene os dados do usuário cadastrado e, portanto, o permita utilizar as funcionalidades da plataforma

### 5. Fluxos de evento

#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O visitante aperta no botão "Cadastrar-se" | --- |
| --- |2. O sistema redireciona o visitante para a página de cadastro de usuário | --- |
|3. O visitante insere os seus dados (Nome, Username, E-mail, Senha, Data de Nascimento e Gênero) e clica em "Criar conta" | --- |
|--- |4. O sistema valida e armazena os dados cadastrados |
|5. O visitante é redirecionado para a página inicial de leitor | --- |

#### 5.2. Fluxo de excessão

##### 5.2.1 Nome em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não insere seu Nome e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Nome' é obrigatório") |

##### 5.2.2 Username em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não insere seu Username e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Username' é obrigatório") |

##### 5.2.3 E-mail em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não insere seu E-mail e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'E-mail' é obrigatório") |

##### 5.2.4 Senha em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não insere sua Senha e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Senha' é obrigatório") |

##### 5.2.5 Data de Nascimento em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não seleciona sua Data de Nascimento e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Data de Nascimento' é obrigatório") |

##### 5.2.6 Gênero em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante não seleciona seu Gênero e clica em "Criar conta" | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Gênero' é obrigatório") |

##### 5.2.7 Nome muito curto
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere um Nome muito curto | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Nome' deve ser composto por, no mínimo, quatro letras") |

##### 5.2.8 Nome inválido
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere um Nome inválido | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Nome' deve ser composto somente por letras") |

##### 5.2.9 Username muito curto
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere um Username muito curto | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Username' deve ser composto por, no mínimo, quatro caracteres") |

##### 5.2.10 E-mail inválido
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere um E-mail inválido | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("Este não é um endereço de E-mail válido") |

##### 5.2.11 Senha muita curta
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere uma Senha muito curta | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Senha' deve ser composto por, no mínimo, oito caracteres") |

##### 5.2.12 Senha muito fraca
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante insere uma Senha muito fraca | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("O campo 'Senha' deve possuir letras maiúsculas e minúsculas, número e caractere especial") |

##### 5.2.13 Data de Nascimento inválida
|  Ator  | Sistema |
|:-------|:------- |
|3. O visitante seleciona uma Data de Nascimento inválida | --- |
|--- |4. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro ("Esta não é uma data válida") |

### 6. Protótipos de Interface
#### 6.1. Página inicial do sistema
![pagina de visitante](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/3ca8d765-60e6-4381-8a62-0d156fe3361d)

#### 6.2. Página de cadastro de usuário
![pagina de cadastro de usuario](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/a1b105ce-2153-4a69-a54e-2fc428912acd)

#### 6.3. Página inicial de usuário autenticado
![pagina inicial autenticado](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/c971e836-28e0-43a0-9abf-546a1d15ce08)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- Nome - Uma cadeia de caracteres alfabéticos tamanho 30
- Username - Uma cadeia de caracteres alfanuméricos tamanho 15
- E-mail - Uma cadeia de caracteres alfanuméricos tamanho 30
- Senha - Uma cadeia de caracteres alfanuméricos tamanho 20
- Data de Nascimento - Data do calendário em modelo DD/MM/AAAA
- Gênero - "Masculino", "Feminino" ou "Outro"

### 9. Regras de negócio
- Nome - Mínimo de 4 caracteres; iniciado por letras maiúsculas
- Username - Mínimo de 4 caracteres
- E-mail - Um conjunto de caracteres (com exceção dos caracteres especiais, sendo permitido apenas o ponto) seguidos, respectivamente, por um arroba, outro conjunto de letras e um ou mais domínios de topo
- Senha - Mínimo de 8 caracteres; pelo menos uma letra maiúscula e minúscula; um número; um caractere especial
- Data de Nascimento - O valor de AAAA deve estar entre 1905 e 2023
