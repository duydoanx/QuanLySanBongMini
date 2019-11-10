create database sanbong;
use sanbong;

--Bang luu tru thong tin dang nhap
create table UserLogin(
	userId int IDENTITY(1,1) primary key,
	username varchar(50) not null,
	password varchar(50) not null,
	isAdmin bit not null,
	dateCreate datetime not null default getdate()
);

select * from UserLogin where username = 'duydoan' and password = '1230456';

drop table UserLogin;
select * from UserLogin; 