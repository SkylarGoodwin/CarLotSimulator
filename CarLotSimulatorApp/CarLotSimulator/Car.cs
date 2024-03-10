using System;

namespace CarLotSimulator
{

	public class Car
	{
		public Car()
		{
		}

        public Car(string make, string model, int year, string honkNoise, string engineNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            IsDriveable = isDriveable;
        }

        public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string HonkNoise { get; set; }
		public string EngineNoise { get; set; }
		public bool IsDriveable { get; set; }

		public string MakeEngineNoise ()
		{
			return EngineNoise; 
		}
		public string MakeHonkNoise()
		{
			return HonkNoise; 
		}
	}
 }