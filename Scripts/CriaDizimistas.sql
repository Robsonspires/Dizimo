USE [DB_Dizimo]
GO

INSERT INTO [dbo].[Dizimistas]
           ([Nome]
           ,[DataNascimento]
           ,[CpfCnpj]
           ,[Email]
           ,[Fone]
           ,[CEP]
           ,[Endereco]
           ,[Complemento]
           ,[Bairro]
           ,[Cidade]
           ,[UF]
           ,[DataCadastro]
           ,[DataAtualizacao])
     VALUES
			('Fabricio', GETDATE(), '222.222.222-22',
            'email@email.com', '27 99999-9999', '29.200-501',
			'Rua da esquiina quebrada', 'Casa', 'São Judas',
			'Guarapari', 'ES', GETDATE(),  GETDATE()),
            ('Delermando', GETDATE(), '222.222.222-22',
            'email@email.com', '27 99999-9999', '29.200-501',
			'Rua da esquiina quebrada', 'Casa', 'São Judas',
			'Guarapari', 'ES', GETDATE(),  GETDATE()),
			('Princiana', GETDATE(), '333.333.333-33',
            'email@email.com', '27 99999-9999', '29.200-502',
			'Rua da esquiina quebrada', 'Casa', 'Ipiranga',
			'Guarapari', 'ES', GETDATE(),  GETDATE()),
			('Willian', GETDATE(), '444.444.444-44',
            'email@email.com', '27 99999-9999', '29.200-503',
			'Rua da esquiina quebrada', 'Casa', 'Centro',
			'Anchieta', 'ES', GETDATE(),  GETDATE()),
			('Gloria', GETDATE(), '555.555.555-55',
            'email@email.com', '27 99999-9999', '29.200-504',
			'Rua da esquiina quebrada', 'Casa', 'Muquiçaba',
			'Guarapari', 'ES', GETDATE(),  GETDATE()),
			('Nick', GETDATE(), '666.666.666-66',
            'email@email.com', '27 99999-9999', '29.200-500',
			'Rua da esquiina quebrada', 'Casa', 'Centro',
			'Guarapari', 'ES', GETDATE(),  GETDATE())
           
GO


