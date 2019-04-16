namespace Team3_Project.Helpers {
	public class ODBAPI {
		public System.String GetAPIinfo(System.String apiString) {
			System.String urlAddress = "http://www.omdbapi.com/?apikey=61c1a60f&" + apiString + "&plot=full";
			System.Net.HttpWebRequest request = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(urlAddress);
			System.Net.HttpWebResponse response = (System.Net.HttpWebResponse) request.GetResponse();
			if (response.StatusCode == System.Net.HttpStatusCode.OK) {
				System.IO.Stream receiveStream = response.GetResponseStream();
				System.IO.StreamReader readStream = response.CharacterSet == null ? new System.IO.StreamReader(receiveStream) : new System.IO.StreamReader(receiveStream , System.Text.Encoding.GetEncoding(response.CharacterSet));
				System.String data = readStream.ReadToEnd();
				response.Close();
				readStream.Close();
				return data;
			}
			return null;
		}
		public void ParseSearch(System.Collections.Generic.List<Watchable> list , System.String response) {
			System.Boolean inResults = false;
			System.String item = "";
			foreach (System.Char c in response) {
				if (c.Equals('[')) {
					inResults = true;
					continue;
				}
				if (c.Equals(']')) {
					inResults = false;
				}
				if (inResults) {
					if (!(c.Equals(',') && item.Equals(""))) {
						item = item + c;
						if (c.Equals('}')) {
							list.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<Watchable>(item));
							item = "";
						}
					}
				}
			}
		}
	}
}