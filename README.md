# Dapper结合AutoFac的ASP.NET MVC框架
> 本套框架主要采用asp.net mvc+dapper+AutoFac搭建的后端框架，虽然项目案例比较简单，但是对于Dapper的操作封装的较为完善，各种复杂查询、分页查询一应俱全。

## 主要技术点：
* 1、asp.net mvc
* 2、dapper 轻量高性能orm框架
* 3、基于接口IService,IRepository，使用AutoFac IOC进行层之间的解耦

## 框架结构说明：
* Quick.Model 实体层，放数据库对应的实体类
* Quick.ORM ORM层，主要是集成Dapper、DapperExtensions
* Quick.IRepository 数据访问接口层
* Quick.Repository 数据访问具体实现层
* Quick.IServices 服务接口层
* Quick.Services 服务具体实现层
* Quick.Web web层

## 开发框架：
vs2019，sqlserver2014，net4.7