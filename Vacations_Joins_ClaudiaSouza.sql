-- Mude o contexto do banco de dados


USE [Vacations_ClaudiaSouza];
GO


-- 12. Fa�a uma consulta de forma a produzir um resultado 'semelhante' � imagem do formul�rio em papel.
-- Usando IIF para deixar as linhas 2 e 3 em branco apenas onde h� repeti��o de dados.
-- Usando a fun��o ROW_NUBER para retornar o n�mero de cada linha usando o conjunto de resultados da cl�usula OVER como input.
-- Usando cl�usula OVER, que define um conjunto de linhas especificado pelo usu�rio (ORDER BY) em um conjunto de resultados de consulta para ROW_NUMBER


SELECT
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, CAST(r.RequestID AS varchar(1)), '') AS 'Request form nro',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, FORMAT(r.RequestDate, 'dd-MM-yyyy'), '') AS 'Request date',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, FORMAT(r.ApprovalDate, 'dd-MM-yyyy'), '') AS 'Approval date',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, m.Code, '') AS 'Manager code',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, CONCAT_WS(' ', m.FirstName, m.SecondName, m.LastName), '') AS 'Manager name',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, e.Code, '') AS 'Employee code',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, CONCAT_WS(' ', e.FirstName, e.SecondName, e.LastName), '') AS 'Employee name',
    IIF(ROW_NUMBER() OVER (ORDER BY v.VacationID) = 1, d.Name, '') AS 'Department',
	v.VacationID AS '#',
	FORMAT(v.StartDate, 'dd-MM-yyyy') AS 'Start date',
	FORMAT(v.EndDate, 'dd-MM-yyyy') AS 'End date',
	v.TotalDays AS 'Total days',
	v.Approved AS 'Approved?'
FROM
    [dbo].[Request] AS r
INNER JOIN
    [dbo].[Employee] AS e 
ON 
	r.EmployeeID = e.EmployeeID
INNER JOIN 
    [dbo].[Employee] AS m 
ON 
	e.Superior = m.EmployeeID
INNER JOIN 
    [dbo].[Department] AS d 
ON 
	e.DepartmentID = d.DepartmentID
INNER JOIN
    [dbo].[Vacation] AS v 
ON 
	r.RequestID = v.RequestID
WHERE
	r.RequestID = 1;
GO


-- Fim.