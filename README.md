# MoneyController
Uma aplicação para Controle Financeiro

Visual Studio 2013

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
