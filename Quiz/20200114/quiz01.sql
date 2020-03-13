.echo on
.headers on

-- Name: Kaiyuan Wang
-- File: quiz01
-- Date: 20200114

drop table if exists family;
create table family (
	id integer primary key,
	name text,
	sex integer,
	role text,
	age integer
);
 
insert into family values (1, 'K', 1, 'parent', 29);
insert into family values (2, 'X', 0, 'parent', 29);
insert into family values (3, 'L', 0, 'child', 4);
insert into family values (4, 'B', 1, 'pet', 10);

select * from family;
select * from family where age > 20 group by sex;