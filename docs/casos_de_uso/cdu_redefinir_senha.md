# Projeto pratelivros

## Especificação do caso de uso - Redefinir senha

### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 10/09/2023 | **1.00** | Primeira versão | Lucas de LIMA |

### 1. Resumo
Este caso de uso permite que um usuário redefina sua senha.

### 2. Atores
- Leitor
- Moderador

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O usuário possuir uma conta cadastrada na plataforma

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Altere a senha do usuário e, portanto, o permita realizar login na plataforma
  
### 5. Fluxos de evento


### 6. Protótipos de Interface
#### 6.1. Página de login
![login](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/6ca18258-afe1-4b4d-b5e6-cc6b6317f6f6)

#### 6.2. Página de redefinição de senha
![redefinir senha](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/a7f54058-68da-4463-98aa-0212eb52def3)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- Username - Uma cadeia de caracteres alfanuméricos tamanho 15
- Senha - Uma cadeia de caracteres alfanuméricos tamanho 20

### 9. Regras de negócio
- Username - Mínimo de 4 caracteres
- Senha - Mínimo de 8 caracteres; pelo menos uma letra maiúscula e minúscula; um número; um caractere especial
