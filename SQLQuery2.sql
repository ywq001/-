--DECLARE @n INT=1,@space INT=3
--WHILE @n<8
--BEGIN
	
--	PRINT space(@space)+replicate(@n,@n)
--	set @n+=2
--	set @space-=1
--END

--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
--CREATE FUNCTION GetBigger(@a INT,@b INT)
--RETURNS INT
--BEGIN
--     DECLARE @RESULT INT
--	 IF @a>@b
--	 set @RESULT=@a
--	 ELSE
--	 SET @RESULT=@b
--	 RETURN @RESULT
--END

--PRINT DBO.GetBigger(3,5)

--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助

--CREATE FUNCTION GetLatestPublish(@n INT)
--RETURNS TABLE
--RETURN SELECT TOP (@n) * FROM Problem ORDER BY pubDate DESC

--创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。

--CREATE FUNCTION GetByReward(@n INT,@asc INT)
--RETURNS @t TABLE(Title NVARCHAR(10))
--AS
--BEGIN
--    IF @asc=1
--	insert @t select top(@n) * from problem order by Reward ASC
--	ELSE
--	insert @t select top(@n) * from problem order by Reward desc
--	RETURN
--END

--在表TProblem中：
--找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写

SELECT * FROM Problem WHERE DATEPART(DW,Createtime)=7 or DATEPART(DW,Createtime)=1
select Author,CAST(ROUND(7*1.0/3,2) AS decimal(10,2)) AS [AVG] FROM Problem GROUP BY Author

UPDATE Problem SET Title='TEST'+SUBSTRING(Title,5,LEN(Title)) WHERE Title LIKE 'test%'