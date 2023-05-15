USE [DB_Dizimo]
GO

INSERT INTO [dbo].[Comunidades]
           ([Nome]
           ,[DataFundacao]
           ,[Cnpj]
           ,[Email]
           ,[Fone]
           ,[CEP]
           ,[Endereco]
           ,[Complemento]
           ,[Bairro]
           ,[Cidade]
           ,[UF])
     VALUES
           ('Divino Esp�rito Santo' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Ipiranga','Guarapari','ES'),
           ('Nossa Senhora do Carmo' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','S�o Jo�o','Guarapari','ES'),
           ('Nossa Senhora Rainha da Paz' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Ipiranga','Guarapari','ES'),
           ('Sagrada Fam�lia' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Praia do Riacho','Guarapari','ES'),
           ('Santa Cruz' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Kubitschek','Guarapari','ES'),
           ('Santa Margarida' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Santa Margarida','Guarapari','ES'),
           ('Santo Expedito' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Concha D`Ostra','Guarapari','ES'),
           ('S�o Jo�o Batista' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Prainha de Olaria','Guarapari','ES'),
           ('S�o Judas Tadeu' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Olaria','Guarapari','ES'),
           ('S�o Sebasti�o' ,GETDATE(), '27.054.162/009620','ofirdev@outlook.com','(27) 99937-1549'
           ,'29.202-515','R. Elizi�rio Louren�o Dias, 505','Com. S�o Judas','Coroado','Guarapari','ES')

GO


