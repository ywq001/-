--alter table student
--add psaaword nvarchar(10) NULL

--insert student(Id) values(1)

--select * from student where psaaword is null

--delete student where [NAME] like '%管理员%' OR [NAME] like '%17bang%'

--alter table student
--add Reward int null

--alter table Problem
--add Reward int null

--insert Problem(Title,Reward) values(N'改变','15')

--update Problem set Title = N'[推荐]'+Title where Reward>10

--select Title from Problem


--alter table Problem
--add pubDate DATETIME NULL

--INSERT Problem(Title,Reward,pubDate) VALUES(N'目标标题','50',2019/10/15)

--UPDATE Problem SET Title=N'[加急]'+Title where Reward>20 AND pubDate>'2019/10/10'

--select title from Problem

--select * from Problem

--INSERT Problem(Title,Reward,pubDate) VALUES(N'目标标题','50','2019/10/15')

--select * from Problem

--UPDATE Problem SET Title=N'[加急]'+Title where Reward>20 AND pubDate>'2019/10/10'

--select title from Problem


--delete Problem where Title like N'#[%#]%' escape'#'

--select title from Problem


--alter table keyword
--add [name] nvarchar(20) not null

--alter table keyword
--add [user] int null
--alter table keyword

--insert keyword values(N'数据库',50)

--select [name] from keyword where [user]>10 and [user]<50

--insert keyword values(N'前端',32)

--select [name] from keyword where [user]>10 and [user]<50

--insert keyword values(N'后端',123)

--update keyword set [user]=1 where [user]<=0 or [user]>100

--select * from keyword


--delete keyword where [user]%2=1

--select * from keyword

--select * from student

--insert student values(2,N'超级管理员',N'ywq',25)

--select * from student


--delete student where [NAME] like N'%管理员%' OR [NAME] like N'%17bang%'



--alter table problem
--add Author NVARCHAR(20) NULL

--insert Problem(Reward,Author) values('10',N'无名')
--insert Problem(Reward,Author) values('25',N'数据库')
--insert Problem(Reward,Author) values('35',N'管理员')
--insert Problem(Reward,Author) values('47',N'超级管理员')

--select * from Problem


--select Title from Problem where Title NOT LIKE N'____数据库%'

--select title from Problem

--insert Problem(Title) values(N'免费的一数据库')
--insert Problem(Title) values(N'数据库表格')
--insert Problem(Title) values(N'表格行列')

--select Title from Problem where Title NOT LIKE N'____数据库%'


select Author,Reward,count(Author) AS [count] from Problem
GROUP BY Author,Reward
order by Reward DESC

--select Author,Reward from Problem

--select Author,Reward,count(Author)AS[COUNT],SUM(Reward)AS[total],AVG(Reward)AS[Average]
--from Problem
--GROUP BY Author,Reward

--select Author,count(Author)AS[COUNT],SUM(Reward)AS[total],AVG(Reward)AS[Average]
--from Problem
--GROUP BY Author

--select Author,Reward from Problem
--order BY Author,Reward DESC

--CREATE TABLE TMessage(
--   Id INT NOT NULL,
--   FromUser NVARCHAR(20),
--   ToUser NVARCHAR(20),
--   UrgentLevel INT,
--   Kind NVARCHAR(20),
--   HasRead BIT,
--   IsDelete BIT,
--   Content NTEXT
--)
--没有约束时没有索引
SELECT [name], is_unique,is_unique_constraint,is_primary_key from sys.indexes
where object_Id=object_Id('TMessage')

alter table TMessage
add constraint UQ_Id UNIQUE(Id)
--添加了唯一约束系统自动添加唯一索引

CREATE UNIQUE INDEX UQ_FromUser ON[TMessage](FromUser)

ALTER TABLE TMessage
add constraint UQ_FromUser_test UNIQUE(FromUser)

--当列中存在唯一索引时，建立唯一约束仍然会新建一个唯一索引，不会使用已有的唯一索引
ALTER TABLE TMessage
DROP CONSTRAINT UQ_Id

--在不删除索引的情况下也可以直接删除约束而不可以直接删除索引，索引约束依赖于索引

--主键上可以是非聚集索引

alter table TMessage
ADD CONSTRAINT PK_Id PRIMARY KEY(Id)

CREATE UNIQUE NONCLUSTERED INDEX IX_Id ON TMessage(Id)

--为Id列添加主键约束，同时也可以在主键上建立非聚集索引

--并利用“执行计划”图演示说明：Scan、Seek和Lookup的使用和区别。
insert TMessage(Id,FromUser) values(1,N'超级管理员')

select *from TMessage where Id=1
--因为ID列中有索引所以使用的是seek，因为索引是聚集索引显示的是Clustered Index Seek

CREATE UNIQUE NONCLUSTERED INDEX IX_UrgentLevel ON TMessage(UrgentLevel)

INSERT TMessage(Id,UrgentLevel) VALUES(2,25)

SELECT * FROM TMessage WHERE UrgentLevel=25

--因为在‘UrgentLevel’列中的是非聚集索引，叶子节点储存的并不是行数据，还要通过lookup进行再次查找

insert TMessage(Id,FromUser,UrgentLevel,Kind) values(3,N'管理员',10,N'数据库')

select * from TMessage where Kind=N'数据库'

--列中没有索引，表中有聚集索引，通过聚集索引进行索引树的遍历，还是会查找整个表的数据。

--SQL SERVER不会为外键添加索引



alter table TMessage
DROP COLUMN userinfo

alter table TMessage
add UserinfoId INT

CREATE TABLE Userinfo(
   Id int not null primary key,
   Age INT,
   Username NVARCHAR(25)
)

ALTER TABLE TMessage
ADD CONSTRAINT FK_Userinfo_Id
FOREIGN KEY (UserinfoId)
REFERENCES Userinfo(Id)
--SQL SERVER并不会为外键添加索引


--作业： 利用循环，打印如下所示的等腰三角形
--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助
--创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。
--在表TProblem中： 		找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位 			
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写

--DECLARE @n INT=1,@space INT
--WHILE(@n<8)
--BEGIN
	
--	PRINT space(@space)+replicate(@n,@n)
--	set @n+=2
--	set @space-=1
--END

--在Problem和Register之间建立主外键关系，

ALTER TABLE Problem
add RegisterId INT

CREATE TABLE Register(
Id INT NOT NULL primary key,
Username NVARCHAR(25) NOT NULL,
[Password] NVARCHAR(25)
)

ALTER TABLE Problem
ADD CONSTRAINT FK_Register_Id
FOREIGN KEY (RegisterId)
REFERENCES Register(Id)

--观察并模拟17bang项目中的：

--用户资料，新建Profile表，和Register形成1:1关联
--求助列表：新建Keyword表，和Problem形成n:n关联
--帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程

CREATE TABLE [Profile](
Id INT NOT NULL,
Isfemale BIT,
birthday DATETIME
)

ALTER TABLE [Profile]
ADD CONSTRAINT PK_Profile_Id PRIMARY KEY(Id)


--求助列表：新建Keyword表，和Problem形成n:n关联
DROP TABLE keyword

CREATE TABLE Keyword(
Id INT PRIMARY KEY,
[NAME] NVARCHAR(25),
[Count] INT
)
ALTER TABLE Problem
ADD Id INT PRIMARY KEY IDENTITY

CREATE TABLE main(
Problem_Id INT,
CONSTRAINT FK_Problem_Id FOREIGN KEY(Problem_Id) REFERENCES Problem(Id),
Keyword_ID INT,
CONSTRAINT FK_Keyword_ID FOREIGN KEY(Keyword_ID) REFERENCES Keyword(Id)
)

--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉）
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到TProblem中
--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，
--然后用新表ProblemStatus存放上述数据
--使用CASE...WHEN，颠倒NewProblem中的NeedRemote（以前是1的，现在变成0；以前是0的，现在变成1）
--使用CASE...WHEN，用一条SQL语句，完成SQL入门-7：函数中第4题第3小题

--DROP TABLE NewProblem

--SELECT Author,Reward 
--INTO NewProblem 
--FROM Problem 
--WHERE Author IS NOT NULL AND Reward IS NOT NULL

--SELECT * FROM NewProblem
--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉）


--INSERT INTO NewProblem(Author,Reward) SELECT Author,Reward FROM Problem WHERE Author IS NULL AND Reward IS NULL
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中

--SELECT AVG(Reward) OVER(PARTITION BY Author) AS AVERAGE,
--MAX(Reward) OVER(PARTITION BY Author)AS BEST,
--MIN(Reward) OVER(PARTITION BY Author)AS LEAST,
--Id,Author
--INTO ProblemStatus
--FROM Problem

--SELECT * FROM ProblemStatus
--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，
--然后用新表ProblemStatus存放上述数据

--SELECT * FROM NewProblem
--ALTER TABLE NewProblem
--ADD NeedRemote BIT NULL
--UPDATE NewProblem SET NeedRemote = CASE WHEN NeedRemote = 1 THEN 0 ELSE 1 END



--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
--UPDATE Problem SET Title =
--CASE
--    WHEN Title LIKE N'test%' THEN N'TEST'+SUBSTRING(Title,5,LEN(Title))
--	WHEN Title LIKE N'#[test#]%'ESCAPE '#'   THEN N'[TEST]'+SUBSTRING(Title,7,LEN(Title)

--END
--WHERE Title LIKE N'test%' OR Title LIKE N'#[Test#]%' ESCAPE '#'

--删除每个作者悬赏最低的求助

DELETE Problem WHERE Id IN
(SELECT Id FROM Problem P1
WHERE Reward = (SELECT MIN(Reward) FROM Problem P2
WHERE P1.Author=P2.Author))
--找到从未成为邀请人的用户




--查出所有发布一篇以上（不含一篇）文章的用户信息

SELECT * FROM Problem
WHERE Id NOT IN (SELECT Id FROM Problem
WHERE Author NOT IN (SELECT Author FROM Problem GROUP BY Author HAVING COUNT(*)<=1))


--为求助添加一个发布时间（PublishTime），查找每个作者最近发布的一篇文章
ALTER TABLE Problem
ADD PublishTime DATETIME

SELECT * FROM Problem s
WHERE PublishTime = (
SELECT MAX(PublishTime)AS b FROM Problem c
WHERE s.Author=c.Author
GROUP BY Author
)


--查出每一篇求助的悬赏都大于5个帮帮币的作者

SELECT Author FROM Problem
GROUP BY Author
HAVING MIN(Reward)>5


--一起帮每月各发布了求助多少篇

SELECT * FROM Problem

SELECT [TIME],COUNT(*) AS [Count] FROM(
SELECT MONTH(PublishTime) AS [TIME] FROM Problem) Y
GROUP BY Y.TIME

--每月发布的求助中，悬赏最多的3篇
SELECT * FROM(
    SELECT 
	ROW_NUMBER() OVER(PARTITION BY te ORDER BY Reward DESC)AS n,
	* 
	FROM(
		SELECT MONTH(PublishTime)AS te,Reward FROM Problem) AS I
) AS e
WHERE e.n BETWEEN 1 AND 3

--每个作者，每月发布的，悬赏最多的3篇

SELECT * FROM(
SELECT ROW_NUMBER() 
OVER(PARTITION BY Author,MONTH(PublishTime) ORDER BY Reward DESC)
AS A,Reward,Author,MONTH(PublishTime)AS C FROM Problem)AS R
WHERE R.A BETWEEN 1 AND 3

--分别按发布时间和悬赏数量进行分页查询的结果
SELECT * FROM Problem ORDER BY PublishTime
OFFSET 4 ROWS                          
FETCH NEXT 2 ROWS ONLY 
SELECT * FROM Problem ORDER BY Reward
OFFSET 4 ROWS                          
FETCH NEXT 2 ROWS ONLY 


--联表查出求助的标题和作者用户名
--ALTER TABLE Userinfo
--ADD [Password] NVARCHAR(25)

--ALTER TABLE Problem
--ADD AuthorId INT

--ALTER TABLE Problem
--ADD CONSTRAINT FK_Userinfo_Id
--FOREIGN KEY (AuthorId)
--REFERENCES Userinfo(Id)

SELECT S.Title,c.Username FROM Problem s JOIN Userinfo c
ON s.AuthorId=c.Id


--查找并删除从未发布过求助的用户
insert Userinfo VALUES(3,23,N'阿泰',N'123456')

DELETE Problem WHERE Author IS NULL

SELECT * FROM Problem

DELETE Userinfo
FROM Userinfo u LEFT JOIN Problem p ON u.Id=p.AuthorId
WHERE p.AuthorId IS NULL

--IF 3 NOT IN (3, 5, NULL) PRINT 'YES'

--用一句SELECT显示出用户和他的邀请人用户名

ALTER TABLE Userinfo
ADD InviterId INT

--ALTER TABLE Userinfo
--ADD CONSTRAINT FK_InviterId
--FOREIGN KEY (InviterId)
--REFERENCES Userinfo(Id)

SELECT * FROM Userinfo a JOIN Userinfo b
ON a.InviterId = b.Id


--17bang的关键字有“一级”“二级”和其他“普通级”的区别：
--请在表Keyword中添加一个字段，记录这种关系
--然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称
ALTER TABLE Keyword
ADD Hierarchy INT

SELECT K1.NAME,K2.NAME,K3.NAME
FROM Keyword K1 left JOIN Keyword K2 ON K1.Hierarchy = K2.Id
                left JOIN Keyword K3 ON K2.Hierarchy = K3.Id
				
				







--17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，
--但是：建议和文章没有悬赏（Reward）
--建议多一个类型：Kind NVARCHAR(20)）
--文章多一个分类：Category INT）
--请按上述描述建表。
--然后，用一个SQL语句按显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列
CREATE TABLE Suggest(
  Id INT PRIMARY KEY,
  Title NVARCHAR(25),
  Content NTEXT,
  PublishTime DATETIME,
  Auhthor NVARCHAR(25)
)
ALTER TABLE Suggest
ADD Kind NVARCHAR(20)


CREATE TABLE Article(
  Id INT PRIMARY KEY,
  Title NVARCHAR(25),
  Content NTEXT,
  PublishTime DATETIME,
  Auhthor NVARCHAR(25),
  Category INT
)



SELECT Title,Content,PublishTime FROM Problem
UNION
SELECT Title,Content,PublishTime FROM Suggest
UNION
SELECT Title,Content,PublishTime FROM Article
WHERE Auhthor = N'数据库'
ORDER BY PublishTime


--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)

--CREATE TABLE Response(
--   Id INT PRIMARY KEY,
--   Content NVARCHAR(4000),
--   AuthorId INT FOREIGN KEY REFERENCES Userinfo(Id),
--   ProblemId INT FOREIGN KEY REFERENCES Problem(Id),
--   CreateTime DATETIME
--)
--然后生成一个视图 VResponse(ResponseId, Content,  
--ReponseAuthorName, ProblemId, ProblemAuthorName, ProblemTitle, CreateTimeA)，要求该视图： 		
--能展示应答作者的用户名、应答对应求助的标题和作者用户名 	（JOIN）		
--只显示求助悬赏值大于5的数据   （JOIN）
--已被加密
--保证其使用的基表结构无法更改

go

--DROP VIEW VResponse
--GO
--CREATE VIEW VResponse
--WITH ENCRYPTION,SCHEMABINDING
--AS
--SELECT 
--r.Id AS ResponseId,r.Content,r.ProblemId,p.Title AS problemTitle,r.CreateTime,r.AuthorId,ur.Username AS ReponseAuthorName,up.Username AS ProblemAuthorName
--FROM dbo.Response r JOIN dbo.Problem p ON r.ProblemId = p.Id
--                    JOIN dbo.Userinfo up ON p.AuthorId = up.Id
--					JOIN dbo.Userinfo ur ON r.AuthorId = ur.Id

--SELECT * FROM VResponse

--演示：在VVResponse中插入一条数据，却不能在视图中显示

--ALTER VIEW VResponse
--AS
--SELECT Reward FROM Problem

--INSERT VResponse(Reward) VALUES(2)

--修改Response，让其能避免上述情形

--ALTER VIEW VResponse
--AS
--SELECT R.Id,R.Content,R.AuthorId,R.ProblemId,U.Username,P.Title,R.CreateTime,P.Reward FROM dbo.Response R
--INNER JOIN dbo.Problem P ON R.Id = P.Id
--INNER JOIN dbo.Userinfo U ON R.Id = U.Id
--WHERE Reward>5
--WITH CHECK OPTION

--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图： 		
--能反映求助的标题、使用关键字数量和悬赏
--在ProblemId上有一个唯一聚集索引 
--在ProblemReward上有一个非聚集索引

CREATE VIEW VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
 AS
 SELECT 
	p.Id, p.Title, p.Reward, pkc.KeywordCount
 FROM
	Problem p 
	JOIN (SELECT Problem_Id, COUNT(*) AS KeywordCount
				FROM main 
				GROUP BY Problem_Id)  pkc 
	On p.Id = pkc.Problem_Id

	go
 CREATE UNIQUE CLUSTERED INDEX IX_ProblemId
 ON VProblemKeyword(ProblemId)

 GO
ALTER VIEW VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
WITH SCHEMABINDING
AS
SELECT 
	p.Id, p.Title, p.Reward, COUNT_BIG(*) AS KeywordCount
FROM
	dbo.Problem p JOIN dbo.main m On p.Id = m.Problem_Id
GROUP BY p.Id,p.Title,p.Reward 
	go


--SELECT 
--	p.Id, p.Title, p.Reward, COUNT(*) AS KeywordCount
--FROM
--	dbo.Problem p JOIN dbo.main m On p.Id = m.Problem_Id
--GROUP BY p.Id, p.Title, p.Reward  


CREATE UNIQUE NONCLUSTERED INDEX IX_ProblemReward
ON VProblemKeyword(ProblemReward)

INSERT main VALUES(8,2)
INSERT main VALUES(8,3)
INSERT main VALUES(8,4)
INSERT main VALUES(8,5)

SELECT * FROM VProblemKeyword


--用户（Reigister）发布一篇悬赏币若干的求助（Problem），他的帮帮币（BMoney）也会相应减少，但他的帮帮币总额不能少于0分：请综合使用TRY...CATCH和事务完成上述需求。

CREATE TABLE BMoney(
 Id INT PRIMARY KEY,
 [Name] NVARCHAR(25),
 BangMoney INT
)


GO
BEGIN TRY
BEGIN TRAN
SAVE TRAN inner_tran
DECLARE @NUM INT = 10
       INSERT Problem(Reward,Author,AuthorId) VALUES(@NUM,N'数据库',1)
	   UPDATE BMoney SET BangMoney -= @NUM WHERE Id = (SELECT Id FROM BMoney WHERE [Name] = N'数据库')
	   COMMIT TRAN
END TRY
BEGIN CATCH
       ROLLBACK; 
	   THROW;
	   PRINT N'提交失败！'
END CATCH


PRINT @@TRANCOUNT

DBCC USEROPTIONS

BEGIN TRANSACTION
UPDATE BMoney SET BangMoney += 50 WHERE [Name]=N'数据库'
COMMIT TRAN

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN
UPDATE BMoney SET BangMoney += 30 WHERE [Name] = N'管理员'
COMMIT TRAN


SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT * FROM BMoney 
COMMIT TRAN

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
UPDATE BMoney SET BangMoney = 20