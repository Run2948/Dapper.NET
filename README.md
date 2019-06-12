# 基于Dapper的ASP.NET简单三层
> 虽然项目案例比较简单，但是对于Dapper的操作封装的较为完善，各种复杂查询、分页查询一应俱全。
> 
## 主要技术点：
* 1、asp.net webapi 基于net技术的webapi
* 2、dapper 轻量高性能orm框架
* 3、三层架构，简单实用的DAL，BLL，WEB层架构

## 框架结构说明：
* Quick.Entity 实体层，放数据库对应的实体类
* Quick.ORM ORM层，主要是集成Dapper、DapperExtensions
* Quick.DAL 数据访问层，主要是对数据库进行访问，通过ORM层进行表和实体的转换
* Quick.BLL 业务逻辑层，主要是业务方面的逻辑
* Quick.Web web层

## 开发框架：
vs2019，sqlserver2014，net4.7