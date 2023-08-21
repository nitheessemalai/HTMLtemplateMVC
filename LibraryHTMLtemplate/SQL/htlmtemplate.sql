create table HTMLtemplate
(
id int primary key identity(1,1),
name nvarchar (500)not null,
phonenumber bigint not null,
emailaddress nvarchar (500) not null,
massage nvarchar(500) not null,
)
select * from  HTMLtemplate
 create or alter  procedure listHTMLtemplatesp
 as
 begin
 select * from HTMLtemplate
 end
 exec  listHTMLtemplatesp
 --insertsp
 create procedure insertHTMLtemplatesp(@name nvarchar (500),@phonenumber bigint ,@emailaddress nvarchar (500),@massage nvarchar(500))
 as 
 begin
 insert into HTMLtemplate (name,phonenumber,emailaddress,massage)values(@name,@phonenumber,@emailaddress,@massage)
 end 
 --exec  insertHTMLtemplatesp' ben ',1234510101 ,'benben@gmail.com', 'Hello' 
  exec  insertHTMLtemplatesp' joo ',2022510101 ,'joojoo@gmail.com', 'loo' 
