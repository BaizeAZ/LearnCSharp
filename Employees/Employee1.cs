using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public abstract partial class Employee
    {
        // 包含/委托编程
        //包含一个BenefitPackage类的对象
        protected BenefitPackage empBenefits=new BenefitPackage();

        //用自定义属性公开对象        
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        //公开对象的保险金行为（成员方法）
        public double GetBenefitsCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        
        
    }
}
