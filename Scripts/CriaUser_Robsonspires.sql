USE [DB_Dizimo]
GO

INSERT INTO [dbo].[Usuarios]
           ([Nome]
           ,[Login]
           ,[Senha]
           ,[Email]
           ,[Perfil]
           ,[DataCadastro]
           ,[DataAtualizacao]
           ,[ComunidadeId])
     VALUES
           ('Robson de Souza Pires' ,'Robsonspires' ,'2ba733e086e7c2f98b3a193782146ad21060c051'
           ,'ofirdev@outlook.com' ,1 ,GETDATE() ,GETDATE() ,9),
			('Rosangela M. Pires' ,'Rosangela' ,'2ba733e086e7c2f98b3a193782146ad21060c051'
           ,'ofirdev@outlook.com' ,2 ,GETDATE() ,GETDATE() ,5),
		   ('Teste de Usuario' ,'Teste' ,'2ba733e086e7c2f98b3a193782146ad21060c051'
           ,'ofirdev@outlook.com' ,3 ,GETDATE() ,GETDATE() ,2),
		   ('Testando Usuario' ,'Testando' ,'2ba733e086e7c2f98b3a193782146ad21060c051'
           ,'ofirdev@outlook.com' ,4 ,GETDATE() ,GETDATE() ,7)

GO


