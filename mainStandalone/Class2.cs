using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	static Class2()
	{
		Class2.class5_0 = new Class2.Class5<Class1>();
		Class2.class5_1 = new Class2.Class5<Form0>();
		Class2.class5_2 = new Class2.Class5<User>();
		Class2.class5_3 = new Class2.Class5<Class2.Class3>();
		Class2.class5_4 = new Class2.Class5<Class2.Class4>();
	}

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_0.Prop_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_1.Prop_0;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_2.Prop_0;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2.Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_3.Prop_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class2.Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_4.Prop_0;
		}
	}

	private static readonly Class2.Class5<Class1> class5_0;
	private static readonly Class2.Class5<Form0> class5_1;
	private static readonly Class2.Class5<User> class5_2;
	private static Class2.Class5<Class2.Class3> class5_3;
	private static readonly Class2.Class5<Class2.Class4> class5_4;
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class3
	{
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			T result;
			if (gparam_0 != null && !gparam_0.IsDisposed)
			{
				result = gparam_0;
			}
			else
			{
				if (Class2.Class3.hashtable_0 != null)
				{
					if (Class2.Class3.hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					Class2.Class3.hashtable_0 = new Hashtable();
				}
				Class2.Class3.hashtable_0.Add(typeof(T), null);
				try
				{
					result = Activator.CreateInstance<T>();
				}
				catch (TargetInvocationException ex) when (ex.InnerException != null)
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
					{
						ex.InnerException.Message
					}), ex.InnerException);
				}
				finally
				{
					Class2.Class3.hashtable_0.Remove(typeof(T));
				}
			}
			return result;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
			
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Equals(object obj)
		{
			return this.method_2(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int GetHashCode()
		{
			return this.method_3();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class2.Class3);
		}
		
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ToString()
		{
			return this.method_4();
		}

		public firstform Firstform_0
		{
			get
			{
				this.firstform_0 = Class2.Class3.smethod_0<firstform>(this.firstform_0);
				return this.firstform_0;
			}
			set
			{
				if (value != this.firstform_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<firstform>(ref this.firstform_0);
				}
			}
		}

		public Form1 Form1_0
		{
			get
			{
				this.form1_0 = Class2.Class3.smethod_0<Form1>(this.form1_0);
				return this.form1_0;
			}
			set
			{
				if (value != this.form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form1>(ref this.form1_0);
				}
			}
		}

		public Form2 Form2_0
		{
			get
			{
				this.form2_0 = Class2.Class3.smethod_0<Form2>(this.form2_0);
				return this.form2_0;
			}
			set
			{
				if (value != this.form2_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form2>(ref this.form2_0);
				}
			}
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		string method_4()
		{
			return base.ToString();
		}

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public firstform firstform_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 form1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2 form2_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public bool Equals(object obj)
		{
			return this.method_2(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int GetHashCode()
		{
			return this.method_3();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class2.Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public string ToString()
		{
			return this.method_4();
		}
		
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result;
			if (gparam_0 == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = gparam_0;
			}
			return result;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			base..ctor();
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		string method_4()
		{
			return base.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (Class2.Class5<T>.gparam_0 == null)
				{
					Class2.Class5<T>.gparam_0 = Activator.CreateInstance<T>();
				}
				return Class2.Class5<T>.gparam_0;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			
		}
		
		static void smethod_0()
		{
			
		}

		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;
	}
}
