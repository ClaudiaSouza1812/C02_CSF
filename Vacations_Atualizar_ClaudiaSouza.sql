-- Alterar contexto do banco de dados


USE [Vacations_ClaudiaSouza];
GO


-- 15. Atualizar o primeiro formulário de pedido de férias. Utilize o texto a verde no formulário para substituir os valores originais, textos: 'Lima de França', 'S', 'Sistemas', '31-12-2019', '7', 'Yes'.


-- 1. 'Franco de Lima' para 'Lima de França'


UPDATE 
	[dbo].[Employee]
SET 
	[SecondName] = 'Lima', 
	[LastName] = 'de França'
WHERE 
	[EmployeeID] = 2;
GO


-- 2. 'T' para 'S'


UPDATE 
	[dbo].[Employee]
SET 
	[Code] = STUFF([Code], CHARINDEX('T', [Code], 7), 1, 'S')
WHERE 
	[EmployeeID] = 1;
GO


-- 3. 'Tecnologias' para 'Sistemas'


UPDATE
	[dbo].[Department]
SET
	[Name] = REPLACE([Name], 'Tecnologias', 'Sistemas')
WHERE
	[DepartmentID] = 1;
GO


-- 4. '03-01-2020, 8, No' para '31-12-2019, 7, Yes'


UPDATE
	[dbo].[Vacation]
SET
	[EndDate] = '2019-12-31',
	[TotalDays] = '7',
	[Approved] = 'Yes'
WHERE
	[VacationID] = 3;
GO


-- Fim.