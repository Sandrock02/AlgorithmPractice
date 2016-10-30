using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    /// <summary>
    /// Matrix class for math
    /// </summary>
    /// <remarks>
    /// /*--------------------------------------class comment
    ///     Version   :  V1.0
    ///     Coded by  :  syz
    ///     Date      :  2011-06-16 16:53:40          *星期四*
    /// ----------------------------------------------------
    /// Desciption :
    ///     *       矩阵类
    ///     *       该类中的部分算符重载需要用到VEC类
    /// parameters :
    ///     * 
    /// Methods    :
    ///     *    MAT------构造函数
    ///     *    +  --------两矩阵相加（对应元素分别相加）
    ///     *    -  --------矩阵相减（对应元素分别相减）
    ///     *    *  --------矩阵元素分别相乘（相当于MATLAB中的  .*算符）
    ///     *    /  --------矩阵元素分别相除（相当与MATLAB中的  ./算符）
    ///     * 
    ///     *    +  --------矩阵加实数（所有元素分别加该实数）
    ///     *    -  --------矩阵减实数（所有元素分别减该实数）
    ///     *    *  --------矩阵乘实数（所有元素分别乘该实数）
    ///     *    /  --------矩阵除实数（所有元素分别除该实数）
    ///     *    
    ///     *               以下再次重载四则算符，
    ///     *               如此可以在矩阵左右均可进行与实数的双目运算
    ///     *    +  --------实数加矩阵（所有元素分别加该实数）
    ///     *    -  --------实数减矩阵（所有元素分别减该实数）
    ///     *    *  --------实数乘矩阵（所有元素分别乘该实数）
    ///     *    /  --------[无]---不重载--(即不能用实数除以矩阵)
    ///     *    
    ///     *    |  --------数学意义下的矩阵相乘
    ///     *    |  --------矩阵与向量相乘（线性变换）
    ///     *    ~  --------矩阵转置（向量中~该算符用于求2范数平方）
    /// --------------------------------------------------*/
    /// </remarks>
    public class Matrix
    {
        public int dim1, dim2;  //数组维数
        public double[,] ele;

        public Matrix(int m, int n)
        {
            //构造函数
            dim1 = m;
            dim2 = n;
            //矩阵维数

            ele = new double[m, n];
            //用二维数组构造数学意义下的矩阵
            //矩阵元素保存于对象ele中
        }


        //-------两个矩阵加法算符重载
        //------矩阵元素分别相加
        public static Matrix operator +(Matrix a1, Matrix a2)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a3 = new Matrix(m, n);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a3.ele[i, j] = a1.ele[i, j] + a2.ele[i, j];

            return a3;

        }


        //-------两个矩阵减法算符重载
        //------矩阵元素分别相减
        public static Matrix operator -(Matrix a1, Matrix a2)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a3 = new Matrix(m, n);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a3.ele[i, j] = a1.ele[i, j] - a2.ele[i, j];

            return a3;

        }

        //-------两个矩阵乘法算符重载
        //------矩阵元素分别相乘，相当于MATLAB中的   .*
        // 要求两个矩阵维数相同，矩阵类不进行个数判断
        public static Matrix operator *(Matrix a1, Matrix a2)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a3 = new Matrix(m, n);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a3.ele[i, j] = a1.ele[i, j] * a2.ele[i, j];

            return a3;

        }

        //-------两个矩阵除法算符重载
        //------矩阵元素分别相除，相当于MATLAB中的   ./
        // 要求两个矩阵维数相同，矩阵类不进行个数判断
        public static Matrix operator /(Matrix a1, Matrix a2)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a3 = new Matrix(m, n);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a3.ele[i, j] = a1.ele[i, j] / a2.ele[i, j];

            return a3;
        }

        //矩阵加实数算符重载
        //各分量分别加实数
        public static Matrix operator +(Matrix a1, double x)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] + x;

            return a2;

        }


        //矩阵减实数算符重载
        //各分量分别减实数
        public static Matrix operator -(Matrix a1, double x)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] - x;

            return a2;
        }

        //矩阵乘以实数算符重载
        //各分量分别乘以实数
        public static Matrix operator *(Matrix a1, double x)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] * x;

            return a2;
        }


        //矩阵除以实数算符重载
        //各分量分别除以实数
        public static Matrix operator /(Matrix a1, double x)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] / x;

            return a2;
        }


        //实数加矩阵算符重载
        //各分量分别加实数
        public static Matrix operator +(double x, Matrix a1)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] + x;

            return a2;

        }


        //实数减矩阵算符重载
        //各分量分别减实数
        public static Matrix operator -(double x, Matrix a1)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] - x;

            return a2;
        }

        //实数乘矩阵算符重载
        //各分量分别乘以实数
        public static Matrix operator *(double x, Matrix a1)
        {
            int m, n;
            m = a1.dim1;
            n = a1.dim2;

            Matrix a2 = new Matrix(m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a2.ele[i, j] = a1.ele[i, j] * x;

            return a2;
        }



        //数学上的矩阵相乘
        public static Matrix operator |(Matrix a1, Matrix a2)
        {
            int m, n, p, q;

            m = a1.dim1;
            n = a1.dim2;

            p = a2.dim1;
            q = a2.dim2;

            if (n != p) System.Console.WriteLine("Inner matrix dimensions must agree！");
            //如果矩阵维数不匹配给出告警信息

            //新矩阵，用于存放结果
            Matrix a3 = new Matrix(m, q);

            int i, j;


            for (i = 0; i < m; i++)
                for (j = 0; j < q; j++)
                {
                    a3.ele[i, j] = 0.0;
                    for (int k = 0; k < n; k++)
                        a3.ele[i, j] = a3.ele[i, j] + a1.ele[i, k] * a2.ele[k, j];
                }

            return a3;
        }

        //矩阵乘以向量(线性变换）
        //即 b=Ax
        public static Vector operator |(Matrix A, Vector x)
        {
            int m, n, p;
            m = A.dim1;
            n = A.dim2;

            p = x.dim;

            if (n != p) System.Console.WriteLine("Inner matrix dimensions must agree！");
            //如果矩阵维数不匹配，给出告警信息

            Vector b = new Vector(m);

            for (int i = 0; i < m; i++)
            {
                b.ele[i] = 0.0;

                for (int k = 0; k < n; k++)
                    b.ele[i] = b.ele[i] + A.ele[i, k] * x.ele[k];
            }

            return b;
        }

        //矩阵转置
        public static Matrix operator ~(Matrix A)
        {
            int m, n;
            m = A.dim1;
            n = A.dim2;

            Matrix TA = new Matrix(n, m);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    TA.ele[i, j] = A.ele[j, i];

            return TA;

        }


        public double this[int index1, int index2]
        // 矩阵索引器
        {
            get
            {
                return ele[index1, index2];
            }
            set
            {
                ele[index1, index2] = value;
            }
        }
    }
}
