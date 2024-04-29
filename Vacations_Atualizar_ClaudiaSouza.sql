-- Alterar contexto do banco de dados


USE [Vacations_ClaudiaSouza];
GO


-- 15. Atualizar o primeiro formul�rio de pedido de f�rias. Utilize o texto a verde no formul�rio para substituir os valores originais, textos: 'Lima de Fran�a', 'S', 'Sistemas', '31-12-2019', '7', 'Yes'.


-- 1. 'Franco de Lima' para 'Lima de Fran�a'


UPDATE 
	[dbo].[Employee]
SET 
	[SecondName] = 'Lima', 
	[LastName] = 'de Fran�a'
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