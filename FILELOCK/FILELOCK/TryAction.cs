using System;
using System.Collections.Generic;
using System.Text;

namespace FILELOCK
{
    /// <summary>
    /// 这里由于时间关系，没有定义异常类型，所以异常信息没能按照类型返回
    /// </summary>
    public class TryAction
    {
        /// <summary>
        /// 抽象try
        /// </summary>
        /// <param name="eventHandler">即将执行的方法代理</param>
        /// <param name="errstr">错误信息</param>
        /// <param name="sender">可选参数</param>
        /// <param name="e">可选参数</param>
        /// <returns>true表示没有异常，false表示发生了异常</returns>
        public static bool TryDo(EventHandler eventHandler, ref string errstr, object sender = null, EventArgs e = null)
        {
            try
            {
                eventHandler.Invoke(sender, e);
                return true;
            }
            catch (Exception ex)
            {
                errstr = ex.ToString();
                return false;
            }

        }
    }
}
