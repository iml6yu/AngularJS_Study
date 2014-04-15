using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace FILELOCK
{
    public class FileLock
    {
        string errstr = "";
        /// <summary>
        /// 锁定路径
        /// </summary>
        /// <param name="d">路径信息</param>
        /// <param name="pwd">密码可选</param>
        /// <returns></returns>
        public bool LockDir(DirectoryInfo d, string pwd = "")
        {
            if (SetPWD(d.FullName, pwd))
            {
                return TryAction.TryDo((o, e) =>
                {
                    //重命名
                    d.MoveTo(d.FullName + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");

                }, ref errstr);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 解锁路径
        /// </summary>
        /// <param name="d"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool UnLockDir(DirectoryInfo d, string pwd = "")
        {
            if (CheckPWD(d.FullName, pwd))
            {

                File.Delete(d.FullName + "\\pwd.xml");
                //重命名
                d.MoveTo(d.FullName.Substring(0, d.FullName.LastIndexOf(".")));
            }
            return false;
        }

        /// <summary>
        /// 核对密码
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        private bool CheckPWD(string dirPath, string pwd)
        {
            XmlTextReader read = new XmlTextReader(dirPath + "\\pwd.xml");
            if (read.ReadState == ReadState.Error)
                return true;
            else
            {
                return TryAction.TryDo((o, e) =>
                {
                    while (read.Read())
                        if (read.NodeType == XmlNodeType.Text)
                        {
                            if (pwd == read.Value)
                            {
                                read.Close();
                            }
                            else
                            {
                                read.Close();
                                throw new Exception();
                            }
                        }
                }, ref errstr);
            }
        }
        /// <summary>
        /// 设置密码
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        private bool SetPWD(string dir, string pwd)
        {
            return TryAction.TryDo((o, e) =>
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement xmlelem;
                XmlNode xmlnode;
                XmlText xmltext;
                xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xmldoc.AppendChild(xmlnode);
                xmlelem = xmldoc.CreateElement("", "ROOT", "");
                xmltext = xmldoc.CreateTextNode(pwd);
                xmlelem.AppendChild(xmltext);
                xmldoc.AppendChild(xmlelem);
                xmldoc.Save(dir + "\\pwd.xml");
            }, ref errstr);

        }

    }
}
