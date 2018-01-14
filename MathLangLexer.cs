// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-13 20:49:15

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int SELECT=4;
	public const int FROM=5;
	public const int WHERE=6;
	public const int ORDER_BY=7;
	public const int PROGRAM=8;
	public const int BLOCK=9;
	public const int FIELDS=10;
	public const int TABLES=11;
	public const int REQUEST=12;
	public const int WS=13;
	public const int SL_COMMENT=14;
	public const int ML_COMMENT=15;
	public const int NUMBER=16;
	public const int FIELD=17;
	public const int TEXT=18;
	public const int DOT=19;
	public const int ADD=20;
	public const int SUB=21;
	public const int MUL=22;
	public const int DIV=23;
	public const int GE=24;
	public const int LE=25;
	public const int NEQUALS=26;
	public const int EQUALS=27;
	public const int GT=28;
	public const int LT=29;
	public const int ASSIGN=30;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_SELECT();
	partial void Leave_SELECT();

	// $ANTLR start "SELECT"
	[GrammarRule("SELECT")]
	private void mSELECT()
	{
		Enter_SELECT();
		EnterRule("SELECT", 1);
		TraceIn("SELECT", 1);
		try
		{
			int _type = SELECT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:8: ( 'select' )
			DebugEnterAlt(1);
			// MathLang.g:9:10: 'select'
			{
			DebugLocation(9, 10);
			Match("select"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SELECT", 1);
			LeaveRule("SELECT", 1);
			Leave_SELECT();
		}
	}
	// $ANTLR end "SELECT"

	partial void Enter_FROM();
	partial void Leave_FROM();

	// $ANTLR start "FROM"
	[GrammarRule("FROM")]
	private void mFROM()
	{
		Enter_FROM();
		EnterRule("FROM", 2);
		TraceIn("FROM", 2);
		try
		{
			int _type = FROM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:6: ( 'from' )
			DebugEnterAlt(1);
			// MathLang.g:10:8: 'from'
			{
			DebugLocation(10, 8);
			Match("from"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FROM", 2);
			LeaveRule("FROM", 2);
			Leave_FROM();
		}
	}
	// $ANTLR end "FROM"

	partial void Enter_WHERE();
	partial void Leave_WHERE();

	// $ANTLR start "WHERE"
	[GrammarRule("WHERE")]
	private void mWHERE()
	{
		Enter_WHERE();
		EnterRule("WHERE", 3);
		TraceIn("WHERE", 3);
		try
		{
			int _type = WHERE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:7: ( 'where' )
			DebugEnterAlt(1);
			// MathLang.g:11:9: 'where'
			{
			DebugLocation(11, 9);
			Match("where"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHERE", 3);
			LeaveRule("WHERE", 3);
			Leave_WHERE();
		}
	}
	// $ANTLR end "WHERE"

	partial void Enter_ORDER_BY();
	partial void Leave_ORDER_BY();

	// $ANTLR start "ORDER_BY"
	[GrammarRule("ORDER_BY")]
	private void mORDER_BY()
	{
		Enter_ORDER_BY();
		EnterRule("ORDER_BY", 4);
		TraceIn("ORDER_BY", 4);
		try
		{
			int _type = ORDER_BY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:10: ( 'order by' )
			DebugEnterAlt(1);
			// MathLang.g:12:12: 'order by'
			{
			DebugLocation(12, 12);
			Match("order by"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ORDER_BY", 4);
			LeaveRule("ORDER_BY", 4);
			Leave_ORDER_BY();
		}
	}
	// $ANTLR end "ORDER_BY"

	partial void Enter_T__31();
	partial void Leave_T__31();

	// $ANTLR start "T__31"
	[GrammarRule("T__31")]
	private void mT__31()
	{
		Enter_T__31();
		EnterRule("T__31", 5);
		TraceIn("T__31", 5);
		try
		{
			int _type = T__31;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:13:9: '('
			{
			DebugLocation(13, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__31", 5);
			LeaveRule("T__31", 5);
			Leave_T__31();
		}
	}
	// $ANTLR end "T__31"

	partial void Enter_T__32();
	partial void Leave_T__32();

	// $ANTLR start "T__32"
	[GrammarRule("T__32")]
	private void mT__32()
	{
		Enter_T__32();
		EnterRule("T__32", 6);
		TraceIn("T__32", 6);
		try
		{
			int _type = T__32;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:14:9: ')'
			{
			DebugLocation(14, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__32", 6);
			LeaveRule("T__32", 6);
			Leave_T__32();
		}
	}
	// $ANTLR end "T__32"

	partial void Enter_T__33();
	partial void Leave_T__33();

	// $ANTLR start "T__33"
	[GrammarRule("T__33")]
	private void mT__33()
	{
		Enter_T__33();
		EnterRule("T__33", 7);
		TraceIn("T__33", 7);
		try
		{
			int _type = T__33;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:15:9: ','
			{
			DebugLocation(15, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__33", 7);
			LeaveRule("T__33", 7);
			Leave_T__33();
		}
	}
	// $ANTLR end "T__33"

	partial void Enter_T__34();
	partial void Leave_T__34();

	// $ANTLR start "T__34"
	[GrammarRule("T__34")]
	private void mT__34()
	{
		Enter_T__34();
		EnterRule("T__34", 8);
		TraceIn("T__34", 8);
		try
		{
			int _type = T__34;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: ';'
			{
			DebugLocation(16, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__34", 8);
			LeaveRule("T__34", 8);
			Leave_T__34();
		}
	}
	// $ANTLR end "T__34"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 9);
		TraceIn("WS", 9);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:30:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(30, 3);
			// MathLang.g:30:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(30, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(30, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 9);
			LeaveRule("WS", 9);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 10);
		TraceIn("SL_COMMENT", 10);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:35:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:36:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(36, 3);
			Match("//"); 

			DebugLocation(36, 8);
			// MathLang.g:36:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:36:36: .
					{
					DebugLocation(36, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(36, 40);
			// MathLang.g:36:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:36:40: '\\r'
				{
				DebugLocation(36, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(36, 46);
			Match('\n'); 
			DebugLocation(36, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 10);
			LeaveRule("SL_COMMENT", 10);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 11);
		TraceIn("ML_COMMENT", 11);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:40:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:41:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(41, 3);
			Match("/*"); 

			DebugLocation(41, 8);
			// MathLang.g:41:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:41:36: .
					{
					DebugLocation(41, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(41, 40);
			Match("*/"); 

			DebugLocation(41, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 11);
			LeaveRule("ML_COMMENT", 11);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 12);
		TraceIn("NUMBER", 12);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:48:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:48:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(48, 9);
			// MathLang.g:48:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:48:10: '0' .. '9'
					{
					DebugLocation(48, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(48, 21);
			// MathLang.g:48:21: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:48:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(48, 22);
				Match('.'); 
				DebugLocation(48, 26);
				// MathLang.g:48:26: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:48:27: '0' .. '9'
						{
						DebugLocation(48, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 12);
			LeaveRule("NUMBER", 12);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_FIELD();
	partial void Leave_FIELD();

	// $ANTLR start "FIELD"
	[GrammarRule("FIELD")]
	private void mFIELD()
	{
		Enter_FIELD();
		EnterRule("FIELD", 13);
		TraceIn("FIELD", 13);
		try
		{
			int _type = FIELD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:50:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:50:8: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(50, 8);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(51, 9);
			// MathLang.g:51:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(51, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FIELD", 13);
			LeaveRule("FIELD", 13);
			Leave_FIELD();
		}
	}
	// $ANTLR end "FIELD"

	partial void Enter_TEXT();
	partial void Leave_TEXT();

	// $ANTLR start "TEXT"
	[GrammarRule("TEXT")]
	private void mTEXT()
	{
		Enter_TEXT();
		EnterRule("TEXT", 14);
		TraceIn("TEXT", 14);
		try
		{
			int _type = TEXT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:54:5: ( '\"' ( FIELD )* '\"' )
			DebugEnterAlt(1);
			// MathLang.g:54:7: '\"' ( FIELD )* '\"'
			{
			DebugLocation(54, 7);
			Match('\"'); 
			DebugLocation(54, 11);
			// MathLang.g:54:11: ( FIELD )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>='0' && LA9_0<='9')||(LA9_0>='A' && LA9_0<='Z')||LA9_0=='_'||(LA9_0>='a' && LA9_0<='z')))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:54:11: FIELD
					{
					DebugLocation(54, 11);
					mFIELD(); 

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(54, 18);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TEXT", 14);
			LeaveRule("TEXT", 14);
			Leave_TEXT();
		}
	}
	// $ANTLR end "TEXT"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 15);
		TraceIn("DOT", 15);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:57:4: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:57:9: '.'
			{
			DebugLocation(57, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 15);
			LeaveRule("DOT", 15);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 16);
		TraceIn("ADD", 16);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:59:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:59:9: '+'
			{
			DebugLocation(59, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 16);
			LeaveRule("ADD", 16);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 17);
		TraceIn("SUB", 17);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:60:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:60:9: '-'
			{
			DebugLocation(60, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 17);
			LeaveRule("SUB", 17);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 18);
		TraceIn("MUL", 18);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:61:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:61:9: '*'
			{
			DebugLocation(61, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 18);
			LeaveRule("MUL", 18);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 19);
		TraceIn("DIV", 19);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:62:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:62:9: '/'
			{
			DebugLocation(62, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 19);
			LeaveRule("DIV", 19);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 20);
		TraceIn("GE", 20);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:64:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:64:11: '>='
			{
			DebugLocation(64, 11);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 20);
			LeaveRule("GE", 20);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 21);
		TraceIn("LE", 21);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:65:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:65:11: '<='
			{
			DebugLocation(65, 11);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 21);
			LeaveRule("LE", 21);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NEQUALS();
	partial void Leave_NEQUALS();

	// $ANTLR start "NEQUALS"
	[GrammarRule("NEQUALS")]
	private void mNEQUALS()
	{
		Enter_NEQUALS();
		EnterRule("NEQUALS", 22);
		TraceIn("NEQUALS", 22);
		try
		{
			int _type = NEQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:66:8: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:66:11: '<>'
			{
			DebugLocation(66, 11);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUALS", 22);
			LeaveRule("NEQUALS", 22);
			Leave_NEQUALS();
		}
	}
	// $ANTLR end "NEQUALS"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 23);
		TraceIn("EQUALS", 23);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:67:7: ( '==' )
			DebugEnterAlt(1);
			// MathLang.g:67:11: '=='
			{
			DebugLocation(67, 11);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 23);
			LeaveRule("EQUALS", 23);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 24);
		TraceIn("GT", 24);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:68:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:68:11: '>'
			{
			DebugLocation(68, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 24);
			LeaveRule("GT", 24);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 25);
		TraceIn("LT", 25);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:69:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:69:11: '<'
			{
			DebugLocation(69, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 25);
			LeaveRule("LT", 25);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 26);
		TraceIn("ASSIGN", 26);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:71:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:71:9: '='
			{
			DebugLocation(71, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 26);
			LeaveRule("ASSIGN", 26);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( SELECT | FROM | WHERE | ORDER_BY | T__31 | T__32 | T__33 | T__34 | WS | SL_COMMENT | ML_COMMENT | NUMBER | FIELD | TEXT | DOT | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN )
		int alt10=26;
		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
		try
		{
			alt10 = dfa10.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(10); }
		switch (alt10)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: SELECT
			{
			DebugLocation(1, 10);
			mSELECT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:17: FROM
			{
			DebugLocation(1, 17);
			mFROM(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:22: WHERE
			{
			DebugLocation(1, 22);
			mWHERE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:28: ORDER_BY
			{
			DebugLocation(1, 28);
			mORDER_BY(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:37: T__31
			{
			DebugLocation(1, 37);
			mT__31(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:43: T__32
			{
			DebugLocation(1, 43);
			mT__32(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:49: T__33
			{
			DebugLocation(1, 49);
			mT__33(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:55: T__34
			{
			DebugLocation(1, 55);
			mT__34(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:61: WS
			{
			DebugLocation(1, 61);
			mWS(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:64: SL_COMMENT
			{
			DebugLocation(1, 64);
			mSL_COMMENT(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:75: ML_COMMENT
			{
			DebugLocation(1, 75);
			mML_COMMENT(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:86: NUMBER
			{
			DebugLocation(1, 86);
			mNUMBER(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:93: FIELD
			{
			DebugLocation(1, 93);
			mFIELD(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:99: TEXT
			{
			DebugLocation(1, 99);
			mTEXT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:104: DOT
			{
			DebugLocation(1, 104);
			mDOT(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:108: ADD
			{
			DebugLocation(1, 108);
			mADD(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:112: SUB
			{
			DebugLocation(1, 112);
			mSUB(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:116: MUL
			{
			DebugLocation(1, 116);
			mMUL(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:120: DIV
			{
			DebugLocation(1, 120);
			mDIV(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:124: GE
			{
			DebugLocation(1, 124);
			mGE(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:127: LE
			{
			DebugLocation(1, 127);
			mLE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:130: NEQUALS
			{
			DebugLocation(1, 130);
			mNEQUALS(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:138: EQUALS
			{
			DebugLocation(1, 138);
			mEQUALS(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:145: GT
			{
			DebugLocation(1, 145);
			mGT(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:148: LT
			{
			DebugLocation(1, 148);
			mLT(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:151: ASSIGN
			{
			DebugLocation(1, 151);
			mASSIGN(); 

			}
			break;

		}

	}


	#region DFA
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x1\xFFFF\x4\xC\x5\xFFFF\x1\x1B\x1\x1C\x6\xFFFF\x1\x1F\x1\x22\x1\x24"+
			"\x4\xC\x4\xFFFF\x1\x1C\x7\xFFFF\x5\xC\x1\x2E\x3\xC\x1\xFFFF\x1\x32\x1"+
			"\xC\x1\x34\x3\xFFFF";
		private const string DFA10_eofS =
			"\x35\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x65\x1\x72\x1\x68\x1\x72\x5\xFFFF\x1\x2A\x1\x30\x6\xFFFF\x3"+
			"\x3D\x1\x6C\x1\x6F\x1\x65\x1\x64\x4\xFFFF\x1\x30\x7\xFFFF\x1\x65\x1\x6D"+
			"\x1\x72\x1\x65\x1\x63\x1\x30\x1\x65\x1\x72\x1\x74\x1\xFFFF\x1\x30\x1"+
			"\x20\x1\x30\x3\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7A\x1\x65\x1\x72\x1\x68\x1\x72\x5\xFFFF\x1\x2F\x1\x7A\x6\xFFFF"+
			"\x1\x3D\x1\x3E\x1\x3D\x1\x6C\x1\x6F\x1\x65\x1\x64\x4\xFFFF\x1\x7A\x7"+
			"\xFFFF\x1\x65\x1\x6D\x1\x72\x1\x65\x1\x63\x1\x7A\x1\x65\x1\x72\x1\x74"+
			"\x1\xFFFF\x1\x7A\x1\x20\x1\x7A\x3\xFFFF";
		private const string DFA10_acceptS =
			"\x5\xFFFF\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x2\xFFFF\x1\xD\x1\xE\x1\xF\x1"+
			"\x10\x1\x11\x1\x12\x7\xFFFF\x1\xA\x1\xB\x1\x13\x1\xC\x1\xFFFF\x1\x14"+
			"\x1\x18\x1\x15\x1\x16\x1\x19\x1\x17\x1\x1A\x9\xFFFF\x1\x2\x3\xFFFF\x1"+
			"\x3\x1\x4\x1\x1";
		private const string DFA10_specialS =
			"\x35\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x9\x1\xFFFF\x2\x9\x12\xFFFF\x1\x9\x1\xFFFF\x1\xD\x5\xFFFF\x1\x5"+
				"\x1\x6\x1\x11\x1\xF\x1\x7\x1\x10\x1\xE\x1\xA\xA\xB\x1\xFFFF\x1\x8\x1"+
				"\x13\x1\x14\x1\x12\x2\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x5\xC\x1"+
				"\x2\x8\xC\x1\x4\x3\xC\x1\x1\x3\xC\x1\x3\x3\xC",
				"\x1\x15",
				"\x1\x16",
				"\x1\x17",
				"\x1\x18",
				"",
				"",
				"",
				"",
				"",
				"\x1\x1A\x4\xFFFF\x1\x19",
				"\xA\x1D\x7\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x1A\xC",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x1E",
				"\x1\x20\x1\x21",
				"\x1\x23",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"\x1\x28",
				"",
				"",
				"",
				"",
				"\xA\x1D\x7\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x1A\xC",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x29",
				"\x1\x2A",
				"\x1\x2B",
				"\x1\x2C",
				"\x1\x2D",
				"\xA\xC\x7\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x1A\xC",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"",
				"\xA\xC\x7\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x1A\xC",
				"\x1\x33",
				"\xA\xC\x7\xFFFF\x1A\xC\x4\xFFFF\x1\xC\x1\xFFFF\x1A\xC",
				"",
				"",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( SELECT | FROM | WHERE | ORDER_BY | T__31 | T__32 | T__33 | T__34 | WS | SL_COMMENT | ML_COMMENT | NUMBER | FIELD | TEXT | DOT | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
