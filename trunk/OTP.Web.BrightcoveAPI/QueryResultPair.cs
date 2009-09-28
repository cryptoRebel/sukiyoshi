﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace OTP.Web.BrightcoveAPI
{
	public class QueryResultPair
	{
		private string _query { get; set; }
		private string _json { get; set; }

		public string Query {
			get {
				return HttpUtility.UrlDecode(_query);
			}
		}
		public string JsonResult {
			get {
				return _json;
			}
		}
		public QueryResultPair(string Query, string JsonResult) {
			_query = Query;
			_json = JsonResult;
		}
	}
}
