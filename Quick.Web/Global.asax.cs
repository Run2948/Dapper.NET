using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quick.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoFacRegister();
        }

        /// <summary>
        /// ʹ��AutoFacʵ������ע��
        /// </summary>
        private void AutoFacRegister()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);  //ע��

            builder.RegisterControllers(Assembly.GetExecutingAssembly());  //ע������Controller
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private void SetupResolveRules(ContainerBuilder builder)
        {
            //ֻ��Ҫ���ýӿڲ�IServices����IRepository ������ʵ�ֲ����ͨ������dll����ͨ���޸����dll��·��Ϊ���·�������磺..\Quick.Web\bin\���Ƽ��÷�ʽ��
            //var IServices = Assembly.Load("Quick.IServices");
            var Services = Assembly.Load("Quick.Services");
            //var IRepository = Assembly.Load("Quick.IRepository");
            var Repository = Assembly.Load("Quick.Repository");

            //��������Լ���������Ľӿں�ʵ�־���Service��β����ʵ�ַ���ӿںͷ���ʵ�ֵ�����
            builder.RegisterAssemblyTypes(Services)
              .Where(t => t.Name.EndsWith("Services"))
              .AsImplementedInterfaces().PropertiesAutowired();//�Ѹþ���ʵ����ע��Ϊ�������нӿ�

            //��������Լ�������ݷ��ʲ�Ľӿں�ʵ�־���Repository��β����ʵ�����ݷ��ʽӿں����ݷ���ʵ�ֵ�����
            builder.RegisterAssemblyTypes(Repository)
              .Where(t => t.Name.EndsWith("Repository"))
              .AsImplementedInterfaces().PropertiesAutowired(); //�Ѹþ���ʵ����ע��Ϊ�������нӿ�
        }
    }
}
