using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Services.Description;

namespace Cloud.Common
{
    public class WebServiceInvoke
    {
        private const string CODE_NAMESPACE = "Ewell.WebServicInvoke.Dynamic";
        //private string Url = string.Empty;
        private static Hashtable _DynamicType = new Hashtable();//缓存代理类，避免重复调用生成

        //public WebServiceInvoke(string url)
        //{
        //    this.Url = url;
        //}
        public static object InvokeWebService(string url, string methodname, object[] args, string nameSpace = CODE_NAMESPACE)
        {
            return InvokeWebService(url, string.Empty, methodname, args, CODE_NAMESPACE);
        }
        public static object InvokeWebService(string url, string classname, string methodname, object[] args, string nameSpace = CODE_NAMESPACE)
        {
            if (string.IsNullOrWhiteSpace(classname))
            {
                classname = GetWsClassName(url);
            }

            try
            {
                Type t = null;
                if (!_DynamicType.ContainsKey(classname))
                {
                    //获取WSDL
                    WebClient wc = new WebClient();
                    Stream stream = wc.OpenRead(url + "?WSDL");
                    if (stream != null)
                    {
                        ServiceDescription sd = ServiceDescription.Read(stream);
                        ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
                        sdi.AddServiceDescription(sd, "", "");
                        CodeNamespace cn = new CodeNamespace(nameSpace);

                        //生成客户端代理类代码
                        CodeCompileUnit ccu = new CodeCompileUnit();
                        ccu.Namespaces.Add(cn);
                        sdi.Import(cn, ccu);
                        CSharpCodeProvider csc = new CSharpCodeProvider();
                        ICodeCompiler icc = csc.CreateCompiler();

                        //设定编译参数
                        CompilerParameters cplist = new CompilerParameters();
                        cplist.GenerateExecutable = false;
                        cplist.GenerateInMemory = true;
                        cplist.ReferencedAssemblies.Add("System.dll");
                        cplist.ReferencedAssemblies.Add("System.XML.dll");
                        cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
                        cplist.ReferencedAssemblies.Add("System.Data.dll");

                        //编译代理类
                        CompilerResults cr = icc.CompileAssemblyFromDom(cplist, ccu);
                        if (true == cr.Errors.HasErrors)
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                            {
                                sb.Append(ce.ToString());
                                sb.Append(System.Environment.NewLine);
                            }
                            throw new Exception(sb.ToString());
                        }

                        //生成代理实例，并调用方法
                        System.Reflection.Assembly assembly = cr.CompiledAssembly;
                        t = assembly.GetType(nameSpace + "." + classname, true, true);
                        _DynamicType.Add(classname, t);
                        //
                        stream.Close();
                        stream.Dispose();
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    t = _DynamicType[classname] as Type;
                }
                object obj = Activator.CreateInstance(t);
                System.Reflection.MethodInfo mi = t.GetMethod(methodname);
                return mi.Invoke(obj, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, new Exception(ex.InnerException.StackTrace));
            }
        }

        private static string GetWsClassName(string wsUrl)
        {
            string[] parts = wsUrl.Split('/');
            string[] pps = parts[parts.Length - 1].Split('.');
            return pps[0];
        }
    }
}
