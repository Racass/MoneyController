# MoneyController

*AVISO*: Essa aplicação está desatualizada. Estou planejando rearquitetar a mesma para funcinoar via AZURE, AMAZON WEB ou CSV. Podendo assim ser implementada facilmente em dispositivos IOS e ANDROID cortando a dependencia do SQL. Existem erros na aplicação e ela não cria sozinha as dependencias. É necessários rodar os creates na mão. 
Exceto essas obeservações, a aplicação funciona normalmente. *AVISO*


Uma aplicação para Controle Financeiro

Dependencias: 
Banco de dados SQL com as seguintes tabelas:

          [dbo].[MoneyStorage]
                           Colunas:
                                    Quantia  nchar(50)
                                    Local    nchar(50)
                                    DinCard  nchar(50)
                                    Data     nchar(50)
                                    Hora     nchar(50)
          
  
          [dbo].[MoneyLegacy]
                           Colunas:
                                    Quantia  nchar(50)
                                    Local    nchar(50)
                                    DinCard  nchar(50)
                                    Data     nchar(50)
                                    Hora     nchar(50)
                                    
                                    
                                    
                                    
Todo dia 30 o programa irá copiar os dados do MoneyStorage e mandar para o MoneyLegacy.. Apenas os dados do mês serão utilizados para calculos do programa.
O programa faz cálculos separados para Poupança, Cartão de Crédito e Cartão de Débito


# To Do

* Mudar a forma de armazenamento de SQL para CSV 
* * Criptografar os dados no CSV
* Traduções
* Melhorar o código
* Usar NotSimpleLogger para log DEBUG e FINAL
* Arquitetar para fácil compilação em ANDROID ou IOS
