using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    /// <summary>
    /// Vector Class for math
    /// </summary>
    /// <remarks>
    /// /*--------------------------------------class comment
    ///     Version   :  V1.0
    ///     Coded by  :  syz
    ///     Date      :  2011-06-15 12:50:11          *星期三*
    /// ----------------------------------------------------
    /// Desciption :
    ///             向量类
    /// parameters :
    ///     *   dim------向量维数
    ///     *   ele------向量元素
    ///     * 
    /// Methods    :
    ///     *    =    -----------向量相等
    ///     *                    注意该方法不需要自行编写重载函数，
    ///     *                    c#已经实现了对类的等号算符重载，并禁止
    ///     *                    用户编写等号算符（=）重载函数
    ///     *    +    -----------两向量对应元素相加
    ///     *    -    -----------两向量对应元素相减
    ///     *    *    -----------两向量对应元素相乘（相当于MATLAB中的  .*算符）
    ///     *    /    -----------两向量对应元素相除（相当于MATLAB中的  ./算符）
    ///     *    
    ///     *    +  -----------重载向量加一实数（所有元素）
    ///     *    -  -----------重载向量减一实数（所有元素）
    ///     *    *  -----------重载向量乘一实数（所有元素）
    ///     *    /  -----------重载向量除一实数（所有元素）
    ///     *   
    ///     *    +  -----------重载实数加向量（所有元素）
    ///     *    -  -----------重载实数减向量（所有元素）
    ///     *    *  -----------重载实数乘以向量（所有元素）
    ///     *    /  -----------[无]--不重载--[即不能用实数除以向量]
    ///     * 
    ///     *    |  （VEC1|ve2）----向量内积
    ///     *    ~  （~VEC1）-------向量2范数的平方
    ///     *    -  （-VEC1）-------向量取负
    ///     *    ^  （VEC1^VEC2）---向量外积
    ///     * 
    /// --------------------------------------------------*/
    /// </remarks>
    public class Vector
    {
        public int dim;  //数组维数
        public double[] ele;

        public Vector(int m)
        {
            //构造函数
            dim = m;
            ele = new double[dim];
            //用一维数组构造向量
        }


        //-------两个向量加法算符重载
        //------分量分别相加
        public static Vector operator +(Vector v1, Vector v2)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v3 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v3.ele[j] = v1.ele[j] + v2.ele[j];
            }
            return v3;
        }

        //-----------------向量减法算符重载
        //-----------------分量分别想减
        public static Vector operator -(Vector v1, Vector v2)
        {
            int N0;
            //获取变量维数
            N0 = v1.dim;

            Vector v3 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v3.ele[j] = v1.ele[j] - v2.ele[j];
            }
            return v3;
        }

        //----------------向量乘法算符重载
        //-------分量分别相乘，相当于MATLAB中的  .*算符
        public static Vector operator *(Vector v1, Vector v2)
        {

            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v3 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v3.ele[j] = v1.ele[j] * v2.ele[j];
            }
            return v3;
        }


        //---------------向量除法算符重载
        //--------------分量分别相除，相当于MATLAB中的   ./算符
        public static Vector operator /(Vector v1, Vector v2)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v3 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v3.ele[j] = v1.ele[j] / v2.ele[j];
            }
            return v3;
        }


        //向量减加实数
        //各分量分别加实数
        public static Vector operator +(Vector v1, double a)
        {
            //向量数加算符重载
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] + a;
            }
            return v2;
        }

        //向量减实数
        //各分量分别减实数
        public static Vector operator -(Vector v1, double a)
        {
            //向量数加算符重载
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] - a;
            }
            return v2;
        }


        //向量 数乘
        //各分量分别乘以实数
        public static Vector operator *(Vector v1, double a)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] * a;
            }
            return v2;
        }


        //向量 数除
        //各分量分别除以实数
        public static Vector operator /(Vector v1, double a)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] / a;
            }
            return v2;
        }


        //实数加向量
        public static Vector operator +(double a, Vector v1)
        {
            //向量数加算符重载
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] + a;
            }
            return v2;
        }

        //实数减向量
        public static Vector operator -(double a, Vector v1)
        {
            //向量数加算符重载
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] - a;
            }
            return v2;
        }


        //向量 数乘
        public static Vector operator *(double a, Vector v1)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            Vector v2 = new Vector(N0);

            int j;
            for (j = 0; j < N0; j++)
            {
                v2.ele[j] = v1.ele[j] * a;
            }
            return v2;
        }



        //---------------向量内积
        public static double operator |(Vector v1, Vector v2)
        {
            int N0, M0;

            //获取变量维数
            N0 = v1.dim;

            M0 = v2.dim;

            if (N0 != M0)
                System.Console.WriteLine("Inner vector dimensions must agree！");
            //如果向量维数不匹配，给出告警信息

            double sum;
            sum = 0.0;

            int j;
            for (j = 0; j < N0; j++)
            {
                sum = sum + v1.ele[j] * v2.ele[j];
            }
            return sum;
        }


        //-----------向量外积（相当于列向量，乘以横向量）
        public static Matrix operator ^(Vector v1, Vector v2)
        {
            int N0, M0;

            //获取变量维数
            N0 = v1.dim;

            M0 = v2.dim;

            if (N0 != M0)
                System.Console.WriteLine("Inner vector dimensions must agree！");
            //如果向量维数不匹配，给出告警信息

            Matrix vvmat = new Matrix(N0, N0);

            for (int i = 0; i < N0; i++)
                for (int j = 0; j < N0; j++)
                    vvmat[i, j] = v1[i] * v2[j];

            //返回外积矩阵
            return vvmat;

        }


        //---------------向量模的平方
        public static double operator ~(Vector v1)
        {
            int N0;

            //获取变量维数
            N0 = v1.dim;

            double sum;
            sum = 0.0;

            int j;
            for (j = 0; j < N0; j++)
            {
                sum = sum + v1.ele[j] * v1.ele[j];
            }
            return sum;
        }

        //  负向量 
        public static Vector operator -(Vector v1)
        {
            int N0 = v1.dim;

            Vector v2 = new Vector(N0);

            for (int i = 0; i < N0; i++)
                v2.ele[i] = -v1.ele[i];

            return v2;
        }

        public double this[int index]
        /*------------------------------------------ comment
        Author      : syz 
        Date        : 2011-07-03 19:53:28         
        ---------------------------------------------------
        Desciption  : 创建索引器
         *
        Post Script :
         *
        paramtegers :
         *
        -------------------------------------------------*/
        {
            get
            {
                //get accessor
                return ele[index];

            }
            set
            {
                //set accessor
                ele[index] = value;

            }

        }
    }
}
