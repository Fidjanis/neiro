using static System.Math

namespace _35._2_Kim_project.NeiroNet
{
	class Neiron1()
	{
		private NeironType type;
		private double[] _weights;
		private double[] _inputs;
		private double _otput;
		private double _derivative;//производная функция активации 
		private double a = 0.01;
		//функция активации - логистическая функция
	

		public double[]Weights { get => _weights; set => _weights = value; }

		public double [] Inputs
		{
			get { return _inputs; }
			set { _inputs = value}
		}

		public double Output { get => _output; }
		public double Derivative { get => _derivative; }
		public Neiron1(double[]weights, NeironType type)
		{
			this.type=type
			_weights = weights;
		}
		public void Activator(double[] i, double[] w)
		{
		}
		
}
}
