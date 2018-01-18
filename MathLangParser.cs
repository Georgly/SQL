// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-15 21:15:01

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "SELECT", "FROM", "WHERE", "ORDER_BY", "AS", "PROGRAM", "BLOCK", "FIELDS", "TABLES", "REQUEST", "SORT", "AND", "OR", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "FIELD", "TEXT", "DOT", "ADD", "SUB", "MUL", "DIV", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "ASSIGN", "'('", "')'", "','", "';'"
	};
	public const int EOF=-1;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int SELECT=4;
	public const int FROM=5;
	public const int WHERE=6;
	public const int ORDER_BY=7;
	public const int AS=8;
	public const int PROGRAM=9;
	public const int BLOCK=10;
	public const int FIELDS=11;
	public const int TABLES=12;
	public const int REQUEST=13;
	public const int SORT=14;
	public const int AND=15;
	public const int OR=16;
	public const int WS=17;
	public const int SL_COMMENT=18;
	public const int ML_COMMENT=19;
	public const int NUMBER=20;
	public const int FIELD=21;
	public const int TEXT=22;
	public const int DOT=23;
	public const int ADD=24;
	public const int SUB=25;
	public const int MUL=26;
	public const int DIV=27;
	public const int GE=28;
	public const int LE=29;
	public const int NEQUALS=30;
	public const int EQUALS=31;
	public const int GT=32;
	public const int LT=33;
	public const int ASSIGN=34;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[50+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:79:1: group : ( '(' term ')' | NUMBER | TEXT | table_field | ( '(' exprList ')' ( AS FIELD )? ) );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken NUMBER4=null;
		IToken TEXT5=null;
		IToken char_literal7=null;
		IToken char_literal9=null;
		IToken AS10=null;
		IToken FIELD11=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);
		MathLangParser.table_field_return table_field6 = default(MathLangParser.table_field_return);
		MathLangParser.exprList_return exprList8 = default(MathLangParser.exprList_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER4_tree=null;
		object TEXT5_tree=null;
		object char_literal7_tree=null;
		object char_literal9_tree=null;
		object AS10_tree=null;
		object FIELD11_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(79, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:79:6: ( '(' term ')' | NUMBER | TEXT | table_field | ( '(' exprList ')' ( AS FIELD )? ) )
			int alt2=5;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case 35:
				{
				int LA2_1 = input.LA(2);

				if (((LA2_1>=NUMBER && LA2_1<=TEXT)||LA2_1==35))
				{
					alt2=1;
				}
				else if ((LA2_1==SELECT))
				{
					alt2=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case NUMBER:
				{
				alt2=2;
				}
				break;
			case TEXT:
				{
				alt2=3;
				}
				break;
			case FIELD:
				{
				alt2=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:80:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(80, 6);
				char_literal1=(IToken)Match(input,35,Follow._35_in_group647); if (state.failed) return retval;
				DebugLocation(80, 8);
				PushFollow(Follow._term_in_group650);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(80, 16);
				char_literal3=(IToken)Match(input,36,Follow._36_in_group652); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:81:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(81, 3);
				NUMBER4=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group657); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER4_tree = (object)adaptor.Create(NUMBER4);
				adaptor.AddChild(root_0, NUMBER4_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:82:3: TEXT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(82, 3);
				TEXT5=(IToken)Match(input,TEXT,Follow._TEXT_in_group661); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				TEXT5_tree = (object)adaptor.Create(TEXT5);
				adaptor.AddChild(root_0, TEXT5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:83:3: table_field
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 3);
				PushFollow(Follow._table_field_in_group665);
				table_field6=table_field();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, table_field6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:84:3: ( '(' exprList ')' ( AS FIELD )? )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 3);
				// MathLang.g:84:3: ( '(' exprList ')' ( AS FIELD )? )
				DebugEnterAlt(1);
				// MathLang.g:84:4: '(' exprList ')' ( AS FIELD )?
				{
				DebugLocation(84, 7);
				char_literal7=(IToken)Match(input,35,Follow._35_in_group670); if (state.failed) return retval;
				DebugLocation(84, 9);
				PushFollow(Follow._exprList_in_group673);
				exprList8=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList8.Tree);
				DebugLocation(84, 21);
				char_literal9=(IToken)Match(input,36,Follow._36_in_group675); if (state.failed) return retval;
				DebugLocation(84, 23);
				// MathLang.g:84:23: ( AS FIELD )?
				int alt1=2;
				try { DebugEnterSubRule(1);
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==AS))
				{
					alt1=1;
				}
				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:84:24: AS FIELD
					{
					DebugLocation(84, 26);
					AS10=(IToken)Match(input,AS,Follow._AS_in_group679); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AS10_tree = (object)adaptor.Create(AS10);
					root_0 = (object)adaptor.BecomeRoot(AS10_tree, root_0);
					}
					DebugLocation(84, 28);
					FIELD11=(IToken)Match(input,FIELD,Follow._FIELD_in_group682); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					FIELD11_tree = (object)adaptor.Create(FIELD11);
					adaptor.AddChild(root_0, FIELD11_tree);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(1); }


				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 1, group_StartIndex); }
		}
		DebugLocation(85, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:87:1: mult : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 2);
		TraceIn("mult", 2);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);
		int mult_StartIndex = input.Index;
		object root_0 = null;

		IToken set13=null;
		MathLangParser.group_return group12 = default(MathLangParser.group_return);
		MathLangParser.group_return group14 = default(MathLangParser.group_return);

		object set13_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(87, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:87:5: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:87:7: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(87, 7);
			PushFollow(Follow._group_in_mult693);
			group12=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group12.Tree);
			DebugLocation(87, 13);
			// MathLang.g:87:13: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=MUL && LA3_0<=DIV)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:87:15: ( MUL | DIV ) group
					{
					DebugLocation(87, 15);
					set13=(IToken)input.LT(1);
					set13=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set13), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(87, 30);
					PushFollow(Follow._group_in_mult708);
					group14=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group14.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 2);
			LeaveRule("mult", 2);
			Leave_mult();
			if (state.backtracking > 0) { Memoize(input, 2, mult_StartIndex); }
		}
		DebugLocation(87, 39);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:88:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 3);
		TraceIn("add", 3);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set16=null;
		MathLangParser.mult_return mult15 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult17 = default(MathLangParser.mult_return);

		object set16_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(88, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:88:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:88:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(88, 7);
			PushFollow(Follow._mult_in_add720);
			mult15=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult15.Tree);
			DebugLocation(88, 13);
			// MathLang.g:88:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=ADD && LA4_0<=SUB)))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:88:15: ( ADD | SUB ) mult
					{
					DebugLocation(88, 15);
					set16=(IToken)input.LT(1);
					set16=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set16), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(88, 30);
					PushFollow(Follow._mult_in_add736);
					mult17=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult17.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 3);
			LeaveRule("add", 3);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 3, add_StartIndex); }
		}
		DebugLocation(88, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:89:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 4);
		TraceIn("compare", 4);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set19=null;
		MathLangParser.add_return add18 = default(MathLangParser.add_return);
		MathLangParser.add_return add20 = default(MathLangParser.add_return);

		object set19_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(89, 64);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:89:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:89:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 10);
			PushFollow(Follow._add_in_compare748);
			add18=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add18.Tree);
			DebugLocation(89, 14);
			// MathLang.g:89:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if (((LA5_0>=GE && LA5_0<=LT)))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:16: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(89, 16);
				set19=(IToken)input.LT(1);
				set19=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set19), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(89, 57);
				PushFollow(Follow._add_in_compare778);
				add20=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add20.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 4);
			LeaveRule("compare", 4);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 4, compare_StartIndex); }
		}
		DebugLocation(89, 64);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class and_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and();
	partial void Leave_and();

	// $ANTLR start "and"
	// MathLang.g:90:1: and : compare ( AND compare )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 5);
		TraceIn("and", 5);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);
		int and_StartIndex = input.Index;
		object root_0 = null;

		IToken AND22=null;
		MathLangParser.compare_return compare21 = default(MathLangParser.compare_return);
		MathLangParser.compare_return compare23 = default(MathLangParser.compare_return);

		object AND22_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(90, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:90:4: ( compare ( AND compare )* )
			DebugEnterAlt(1);
			// MathLang.g:90:6: compare ( AND compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 6);
			PushFollow(Follow._compare_in_and789);
			compare21=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare21.Tree);
			DebugLocation(90, 14);
			// MathLang.g:90:14: ( AND compare )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==AND))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:90:15: AND compare
					{
					DebugLocation(90, 18);
					AND22=(IToken)Match(input,AND,Follow._AND_in_and792); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND22_tree = (object)adaptor.Create(AND22);
					root_0 = (object)adaptor.BecomeRoot(AND22_tree, root_0);
					}
					DebugLocation(90, 20);
					PushFollow(Follow._compare_in_and795);
					compare23=compare();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare23.Tree);

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and", 5);
			LeaveRule("and", 5);
			Leave_and();
			if (state.backtracking > 0) { Memoize(input, 5, and_StartIndex); }
		}
		DebugLocation(90, 30);
		} finally { DebugExitRule(GrammarFileName, "and"); }
		return retval;

	}
	// $ANTLR end "and"

	public class or_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or();
	partial void Leave_or();

	// $ANTLR start "or"
	// MathLang.g:91:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 6);
		TraceIn("or", 6);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);
		int or_StartIndex = input.Index;
		object root_0 = null;

		IToken OR25=null;
		MathLangParser.and_return and24 = default(MathLangParser.and_return);
		MathLangParser.and_return and26 = default(MathLangParser.and_return);

		object OR25_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(91, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:91:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:91:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 5);
			PushFollow(Follow._and_in_or805);
			and24=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and24.Tree);
			DebugLocation(91, 9);
			// MathLang.g:91:9: ( OR and )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==OR))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:91:10: OR and
					{
					DebugLocation(91, 12);
					OR25=(IToken)Match(input,OR,Follow._OR_in_or808); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR25_tree = (object)adaptor.Create(OR25);
					root_0 = (object)adaptor.BecomeRoot(OR25_tree, root_0);
					}
					DebugLocation(91, 14);
					PushFollow(Follow._and_in_or811);
					and26=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and26.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or", 6);
			LeaveRule("or", 6);
			Leave_or();
			if (state.backtracking > 0) { Memoize(input, 6, or_StartIndex); }
		}
		DebugLocation(91, 19);
		} finally { DebugExitRule(GrammarFileName, "or"); }
		return retval;

	}
	// $ANTLR end "or"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:92:1: term : or ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 7);
		TraceIn("term", 7);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.or_return or27 = default(MathLangParser.or_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(92, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:92:5: ( or )
			DebugEnterAlt(1);
			// MathLang.g:92:7: or
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 7);
			PushFollow(Follow._or_in_term820);
			or27=or();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or27.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 7);
			LeaveRule("term", 7);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 7, term_StartIndex); }
		}
		DebugLocation(92, 8);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class table_field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_table_field();
	partial void Leave_table_field();

	// $ANTLR start "table_field"
	// MathLang.g:94:1: table_field : ( ( FIELD DOT ( FIELD | '*' ) ) | FIELD );
	[GrammarRule("table_field")]
	private MathLangParser.table_field_return table_field()
	{
		Enter_table_field();
		EnterRule("table_field", 8);
		TraceIn("table_field", 8);
		MathLangParser.table_field_return retval = new MathLangParser.table_field_return();
		retval.Start = (IToken)input.LT(1);
		int table_field_StartIndex = input.Index;
		object root_0 = null;

		IToken FIELD28=null;
		IToken DOT29=null;
		IToken set30=null;
		IToken FIELD31=null;

		object FIELD28_tree=null;
		object DOT29_tree=null;
		object set30_tree=null;
		object FIELD31_tree=null;

		try { DebugEnterRule(GrammarFileName, "table_field");
		DebugLocation(94, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:94:12: ( ( FIELD DOT ( FIELD | '*' ) ) | FIELD )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==FIELD))
			{
				int LA8_1 = input.LA(2);

				if ((LA8_1==DOT))
				{
					alt8=1;
				}
				else if ((LA8_1==EOF||LA8_1==FROM||LA8_1==ORDER_BY||(LA8_1>=AND && LA8_1<=OR)||(LA8_1>=ADD && LA8_1<=LT)||(LA8_1>=36 && LA8_1<=38)))
				{
					alt8=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:94:14: ( FIELD DOT ( FIELD | '*' ) )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 14);
				// MathLang.g:94:14: ( FIELD DOT ( FIELD | '*' ) )
				DebugEnterAlt(1);
				// MathLang.g:94:15: FIELD DOT ( FIELD | '*' )
				{
				DebugLocation(94, 15);
				FIELD28=(IToken)Match(input,FIELD,Follow._FIELD_in_table_field828); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD28_tree = (object)adaptor.Create(FIELD28);
				adaptor.AddChild(root_0, FIELD28_tree);
				}
				DebugLocation(94, 24);
				DOT29=(IToken)Match(input,DOT,Follow._DOT_in_table_field830); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				DOT29_tree = (object)adaptor.Create(DOT29);
				root_0 = (object)adaptor.BecomeRoot(DOT29_tree, root_0);
				}
				DebugLocation(94, 26);
				set30=(IToken)input.LT(1);
				if (input.LA(1)==FIELD||input.LA(1)==MUL)
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set30));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:94:43: FIELD
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 43);
				FIELD31=(IToken)Match(input,FIELD,Follow._FIELD_in_table_field844); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD31_tree = (object)adaptor.Create(FIELD31);
				adaptor.AddChild(root_0, FIELD31_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("table_field", 8);
			LeaveRule("table_field", 8);
			Leave_table_field();
			if (state.backtracking > 0) { Memoize(input, 8, table_field_StartIndex); }
		}
		DebugLocation(94, 47);
		} finally { DebugExitRule(GrammarFileName, "table_field"); }
		return retval;

	}
	// $ANTLR end "table_field"

	public class request_params_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_request_params();
	partial void Leave_request_params();

	// $ANTLR start "request_params"
	// MathLang.g:95:1: request_params : ( '*' | table_field );
	[GrammarRule("request_params")]
	private MathLangParser.request_params_return request_params()
	{
		Enter_request_params();
		EnterRule("request_params", 9);
		TraceIn("request_params", 9);
		MathLangParser.request_params_return retval = new MathLangParser.request_params_return();
		retval.Start = (IToken)input.LT(1);
		int request_params_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal32=null;
		MathLangParser.table_field_return table_field33 = default(MathLangParser.table_field_return);

		object char_literal32_tree=null;

		try { DebugEnterRule(GrammarFileName, "request_params");
		DebugLocation(95, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:95:16: ( '*' | table_field )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==MUL))
			{
				alt9=1;
			}
			else if ((LA9_0==FIELD))
			{
				alt9=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:95:18: '*'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 18);
				char_literal32=(IToken)Match(input,MUL,Follow._MUL_in_request_params851); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal32_tree = (object)adaptor.Create(char_literal32);
				adaptor.AddChild(root_0, char_literal32_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:95:24: table_field
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 24);
				PushFollow(Follow._table_field_in_request_params855);
				table_field33=table_field();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, table_field33.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("request_params", 9);
			LeaveRule("request_params", 9);
			Leave_request_params();
			if (state.backtracking > 0) { Memoize(input, 9, request_params_StartIndex); }
		}
		DebugLocation(95, 34);
		} finally { DebugExitRule(GrammarFileName, "request_params"); }
		return retval;

	}
	// $ANTLR end "request_params"

	public class formal_params_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_formal_params();
	partial void Leave_formal_params();

	// $ANTLR start "formal_params"
	// MathLang.g:96:1: formal_params : ( request_params ( ',' request_params )* ) -> ^( FIELDS ( request_params )+ ) ;
	[GrammarRule("formal_params")]
	private MathLangParser.formal_params_return formal_params()
	{
		Enter_formal_params();
		EnterRule("formal_params", 10);
		TraceIn("formal_params", 10);
		MathLangParser.formal_params_return retval = new MathLangParser.formal_params_return();
		retval.Start = (IToken)input.LT(1);
		int formal_params_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal35=null;
		MathLangParser.request_params_return request_params34 = default(MathLangParser.request_params_return);
		MathLangParser.request_params_return request_params36 = default(MathLangParser.request_params_return);

		object char_literal35_tree=null;
		RewriteRuleITokenStream stream_37=new RewriteRuleITokenStream(adaptor,"token 37");
		RewriteRuleSubtreeStream stream_request_params=new RewriteRuleSubtreeStream(adaptor,"rule request_params");
		try { DebugEnterRule(GrammarFileName, "formal_params");
		DebugLocation(96, 84);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:96:14: ( ( request_params ( ',' request_params )* ) -> ^( FIELDS ( request_params )+ ) )
			DebugEnterAlt(1);
			// MathLang.g:96:16: ( request_params ( ',' request_params )* )
			{
			DebugLocation(96, 16);
			// MathLang.g:96:16: ( request_params ( ',' request_params )* )
			DebugEnterAlt(1);
			// MathLang.g:96:18: request_params ( ',' request_params )*
			{
			DebugLocation(96, 18);
			PushFollow(Follow._request_params_in_formal_params863);
			request_params34=request_params();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_request_params.Add(request_params34.Tree);
			DebugLocation(96, 33);
			// MathLang.g:96:33: ( ',' request_params )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==37))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:96:34: ',' request_params
					{
					DebugLocation(96, 34);
					char_literal35=(IToken)Match(input,37,Follow._37_in_formal_params866); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_37.Add(char_literal35);

					DebugLocation(96, 38);
					PushFollow(Follow._request_params_in_formal_params868);
					request_params36=request_params();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_request_params.Add(request_params36.Tree);

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


			}



			{
			// AST REWRITE
			// elements: request_params
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 96:57: -> ^( FIELDS ( request_params )+ )
			{
				DebugLocation(96, 60);
				// MathLang.g:96:60: ^( FIELDS ( request_params )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(96, 62);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELDS, "FIELDS"), root_1);

				DebugLocation(96, 69);
				if ( !(stream_request_params.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_request_params.HasNext )
				{
					DebugLocation(96, 69);
					adaptor.AddChild(root_1, stream_request_params.NextTree());

				}
				stream_request_params.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("formal_params", 10);
			LeaveRule("formal_params", 10);
			Leave_formal_params();
			if (state.backtracking > 0) { Memoize(input, 10, formal_params_StartIndex); }
		}
		DebugLocation(96, 84);
		} finally { DebugExitRule(GrammarFileName, "formal_params"); }
		return retval;

	}
	// $ANTLR end "formal_params"

	public class select__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_select_();
	partial void Leave_select_();

	// $ANTLR start "select_"
	// MathLang.g:97:1: select_ : SELECT formal_params ;
	[GrammarRule("select_")]
	private MathLangParser.select__return select_()
	{
		Enter_select_();
		EnterRule("select_", 11);
		TraceIn("select_", 11);
		MathLangParser.select__return retval = new MathLangParser.select__return();
		retval.Start = (IToken)input.LT(1);
		int select__StartIndex = input.Index;
		object root_0 = null;

		IToken SELECT37=null;
		MathLangParser.formal_params_return formal_params38 = default(MathLangParser.formal_params_return);

		object SELECT37_tree=null;

		try { DebugEnterRule(GrammarFileName, "select_");
		DebugLocation(97, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:97:8: ( SELECT formal_params )
			DebugEnterAlt(1);
			// MathLang.g:97:10: SELECT formal_params
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 16);
			SELECT37=(IToken)Match(input,SELECT,Follow._SELECT_in_select_887); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			SELECT37_tree = (object)adaptor.Create(SELECT37);
			root_0 = (object)adaptor.BecomeRoot(SELECT37_tree, root_0);
			}
			DebugLocation(97, 18);
			PushFollow(Follow._formal_params_in_select_890);
			formal_params38=formal_params();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formal_params38.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("select_", 11);
			LeaveRule("select_", 11);
			Leave_select_();
			if (state.backtracking > 0) { Memoize(input, 11, select__StartIndex); }
		}
		DebugLocation(97, 30);
		} finally { DebugExitRule(GrammarFileName, "select_"); }
		return retval;

	}
	// $ANTLR end "select_"

	public class tables_or_request_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tables_or_request();
	partial void Leave_tables_or_request();

	// $ANTLR start "tables_or_request"
	// MathLang.g:99:1: tables_or_request : ( FIELD | ( '(' exprList ')' AS FIELD ) );
	[GrammarRule("tables_or_request")]
	private MathLangParser.tables_or_request_return tables_or_request()
	{
		Enter_tables_or_request();
		EnterRule("tables_or_request", 12);
		TraceIn("tables_or_request", 12);
		MathLangParser.tables_or_request_return retval = new MathLangParser.tables_or_request_return();
		retval.Start = (IToken)input.LT(1);
		int tables_or_request_StartIndex = input.Index;
		object root_0 = null;

		IToken FIELD39=null;
		IToken char_literal40=null;
		IToken char_literal42=null;
		IToken AS43=null;
		IToken FIELD44=null;
		MathLangParser.exprList_return exprList41 = default(MathLangParser.exprList_return);

		object FIELD39_tree=null;
		object char_literal40_tree=null;
		object char_literal42_tree=null;
		object AS43_tree=null;
		object FIELD44_tree=null;

		try { DebugEnterRule(GrammarFileName, "tables_or_request");
		DebugLocation(99, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:99:18: ( FIELD | ( '(' exprList ')' AS FIELD ) )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==FIELD))
			{
				alt11=1;
			}
			else if ((LA11_0==35))
			{
				alt11=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:99:20: FIELD
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 20);
				FIELD39=(IToken)Match(input,FIELD,Follow._FIELD_in_tables_or_request897); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD39_tree = (object)adaptor.Create(FIELD39);
				adaptor.AddChild(root_0, FIELD39_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:99:28: ( '(' exprList ')' AS FIELD )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 28);
				// MathLang.g:99:28: ( '(' exprList ')' AS FIELD )
				DebugEnterAlt(1);
				// MathLang.g:99:29: '(' exprList ')' AS FIELD
				{
				DebugLocation(99, 32);
				char_literal40=(IToken)Match(input,35,Follow._35_in_tables_or_request902); if (state.failed) return retval;
				DebugLocation(99, 34);
				PushFollow(Follow._exprList_in_tables_or_request905);
				exprList41=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList41.Tree);
				DebugLocation(99, 46);
				char_literal42=(IToken)Match(input,36,Follow._36_in_tables_or_request907); if (state.failed) return retval;
				DebugLocation(99, 50);
				AS43=(IToken)Match(input,AS,Follow._AS_in_tables_or_request910); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				AS43_tree = (object)adaptor.Create(AS43);
				root_0 = (object)adaptor.BecomeRoot(AS43_tree, root_0);
				}
				DebugLocation(99, 52);
				FIELD44=(IToken)Match(input,FIELD,Follow._FIELD_in_tables_or_request913); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				FIELD44_tree = (object)adaptor.Create(FIELD44);
				adaptor.AddChild(root_0, FIELD44_tree);
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tables_or_request", 12);
			LeaveRule("tables_or_request", 12);
			Leave_tables_or_request();
			if (state.backtracking > 0) { Memoize(input, 12, tables_or_request_StartIndex); }
		}
		DebugLocation(99, 57);
		} finally { DebugExitRule(GrammarFileName, "tables_or_request"); }
		return retval;

	}
	// $ANTLR end "tables_or_request"

	public class request_tables_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_request_tables();
	partial void Leave_request_tables();

	// $ANTLR start "request_tables"
	// MathLang.g:100:1: request_tables : ( tables_or_request ( ',' tables_or_request )* ) -> ^( TABLES ( tables_or_request )+ ) ;
	[GrammarRule("request_tables")]
	private MathLangParser.request_tables_return request_tables()
	{
		Enter_request_tables();
		EnterRule("request_tables", 13);
		TraceIn("request_tables", 13);
		MathLangParser.request_tables_return retval = new MathLangParser.request_tables_return();
		retval.Start = (IToken)input.LT(1);
		int request_tables_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal46=null;
		MathLangParser.tables_or_request_return tables_or_request45 = default(MathLangParser.tables_or_request_return);
		MathLangParser.tables_or_request_return tables_or_request47 = default(MathLangParser.tables_or_request_return);

		object char_literal46_tree=null;
		RewriteRuleITokenStream stream_37=new RewriteRuleITokenStream(adaptor,"token 37");
		RewriteRuleSubtreeStream stream_tables_or_request=new RewriteRuleSubtreeStream(adaptor,"rule tables_or_request");
		try { DebugEnterRule(GrammarFileName, "request_tables");
		DebugLocation(100, 92);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:100:15: ( ( tables_or_request ( ',' tables_or_request )* ) -> ^( TABLES ( tables_or_request )+ ) )
			DebugEnterAlt(1);
			// MathLang.g:100:17: ( tables_or_request ( ',' tables_or_request )* )
			{
			DebugLocation(100, 17);
			// MathLang.g:100:17: ( tables_or_request ( ',' tables_or_request )* )
			DebugEnterAlt(1);
			// MathLang.g:100:18: tables_or_request ( ',' tables_or_request )*
			{
			DebugLocation(100, 18);
			PushFollow(Follow._tables_or_request_in_request_tables921);
			tables_or_request45=tables_or_request();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_tables_or_request.Add(tables_or_request45.Tree);
			DebugLocation(100, 36);
			// MathLang.g:100:36: ( ',' tables_or_request )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==37))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:100:37: ',' tables_or_request
					{
					DebugLocation(100, 37);
					char_literal46=(IToken)Match(input,37,Follow._37_in_request_tables924); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_37.Add(char_literal46);

					DebugLocation(100, 41);
					PushFollow(Follow._tables_or_request_in_request_tables926);
					tables_or_request47=tables_or_request();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_tables_or_request.Add(tables_or_request47.Tree);

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }


			}



			{
			// AST REWRITE
			// elements: tables_or_request
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 100:62: -> ^( TABLES ( tables_or_request )+ )
			{
				DebugLocation(100, 65);
				// MathLang.g:100:65: ^( TABLES ( tables_or_request )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(100, 67);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TABLES, "TABLES"), root_1);

				DebugLocation(100, 74);
				if ( !(stream_tables_or_request.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_tables_or_request.HasNext )
				{
					DebugLocation(100, 74);
					adaptor.AddChild(root_1, stream_tables_or_request.NextTree());

				}
				stream_tables_or_request.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("request_tables", 13);
			LeaveRule("request_tables", 13);
			Leave_request_tables();
			if (state.backtracking > 0) { Memoize(input, 13, request_tables_StartIndex); }
		}
		DebugLocation(100, 92);
		} finally { DebugExitRule(GrammarFileName, "request_tables"); }
		return retval;

	}
	// $ANTLR end "request_tables"

	public class from__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_from_();
	partial void Leave_from_();

	// $ANTLR start "from_"
	// MathLang.g:101:1: from_ : FROM request_tables ;
	[GrammarRule("from_")]
	private MathLangParser.from__return from_()
	{
		Enter_from_();
		EnterRule("from_", 14);
		TraceIn("from_", 14);
		MathLangParser.from__return retval = new MathLangParser.from__return();
		retval.Start = (IToken)input.LT(1);
		int from__StartIndex = input.Index;
		object root_0 = null;

		IToken FROM48=null;
		MathLangParser.request_tables_return request_tables49 = default(MathLangParser.request_tables_return);

		object FROM48_tree=null;

		try { DebugEnterRule(GrammarFileName, "from_");
		DebugLocation(101, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:101:6: ( FROM request_tables )
			DebugEnterAlt(1);
			// MathLang.g:101:8: FROM request_tables
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(101, 12);
			FROM48=(IToken)Match(input,FROM,Follow._FROM_in_from_944); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			FROM48_tree = (object)adaptor.Create(FROM48);
			root_0 = (object)adaptor.BecomeRoot(FROM48_tree, root_0);
			}
			DebugLocation(101, 14);
			PushFollow(Follow._request_tables_in_from_947);
			request_tables49=request_tables();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, request_tables49.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("from_", 14);
			LeaveRule("from_", 14);
			Leave_from_();
			if (state.backtracking > 0) { Memoize(input, 14, from__StartIndex); }
		}
		DebugLocation(101, 27);
		} finally { DebugExitRule(GrammarFileName, "from_"); }
		return retval;

	}
	// $ANTLR end "from_"

	public class orderby_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_orderby();
	partial void Leave_orderby();

	// $ANTLR start "orderby"
	// MathLang.g:103:1: orderby : ( NUMBER ( ',' NUMBER )* ) -> ^( SORT ( NUMBER )+ ) ;
	[GrammarRule("orderby")]
	private MathLangParser.orderby_return orderby()
	{
		Enter_orderby();
		EnterRule("orderby", 15);
		TraceIn("orderby", 15);
		MathLangParser.orderby_return retval = new MathLangParser.orderby_return();
		retval.Start = (IToken)input.LT(1);
		int orderby_StartIndex = input.Index;
		object root_0 = null;

		IToken NUMBER50=null;
		IToken char_literal51=null;
		IToken NUMBER52=null;

		object NUMBER50_tree=null;
		object char_literal51_tree=null;
		object NUMBER52_tree=null;
		RewriteRuleITokenStream stream_NUMBER=new RewriteRuleITokenStream(adaptor,"token NUMBER");
		RewriteRuleITokenStream stream_37=new RewriteRuleITokenStream(adaptor,"token 37");

		try { DebugEnterRule(GrammarFileName, "orderby");
		DebugLocation(103, 51);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:103:9: ( ( NUMBER ( ',' NUMBER )* ) -> ^( SORT ( NUMBER )+ ) )
			DebugEnterAlt(1);
			// MathLang.g:103:11: ( NUMBER ( ',' NUMBER )* )
			{
			DebugLocation(103, 11);
			// MathLang.g:103:11: ( NUMBER ( ',' NUMBER )* )
			DebugEnterAlt(1);
			// MathLang.g:103:12: NUMBER ( ',' NUMBER )*
			{
			DebugLocation(103, 12);
			NUMBER50=(IToken)Match(input,NUMBER,Follow._NUMBER_in_orderby956); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER50);

			DebugLocation(103, 19);
			// MathLang.g:103:19: ( ',' NUMBER )*
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if ((LA13_0==37))
				{
					alt13=1;
				}


				} finally { DebugExitDecision(13); }
				switch ( alt13 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:103:20: ',' NUMBER
					{
					DebugLocation(103, 20);
					char_literal51=(IToken)Match(input,37,Follow._37_in_orderby959); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_37.Add(char_literal51);

					DebugLocation(103, 24);
					NUMBER52=(IToken)Match(input,NUMBER,Follow._NUMBER_in_orderby961); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_NUMBER.Add(NUMBER52);


					}
					break;

				default:
					goto loop13;
				}
			}

			loop13:
				;

			} finally { DebugExitSubRule(13); }


			}



			{
			// AST REWRITE
			// elements: NUMBER
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 103:34: -> ^( SORT ( NUMBER )+ )
			{
				DebugLocation(103, 37);
				// MathLang.g:103:37: ^( SORT ( NUMBER )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(103, 39);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SORT, "SORT"), root_1);

				DebugLocation(103, 44);
				if ( !(stream_NUMBER.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_NUMBER.HasNext )
				{
					DebugLocation(103, 44);
					adaptor.AddChild(root_1, stream_NUMBER.NextNode());

				}
				stream_NUMBER.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("orderby", 15);
			LeaveRule("orderby", 15);
			Leave_orderby();
			if (state.backtracking > 0) { Memoize(input, 15, orderby_StartIndex); }
		}
		DebugLocation(103, 51);
		} finally { DebugExitRule(GrammarFileName, "orderby"); }
		return retval;

	}
	// $ANTLR end "orderby"

	public class orderby__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_orderby_();
	partial void Leave_orderby_();

	// $ANTLR start "orderby_"
	// MathLang.g:104:1: orderby_ : ORDER_BY orderby ;
	[GrammarRule("orderby_")]
	private MathLangParser.orderby__return orderby_()
	{
		Enter_orderby_();
		EnterRule("orderby_", 16);
		TraceIn("orderby_", 16);
		MathLangParser.orderby__return retval = new MathLangParser.orderby__return();
		retval.Start = (IToken)input.LT(1);
		int orderby__StartIndex = input.Index;
		object root_0 = null;

		IToken ORDER_BY53=null;
		MathLangParser.orderby_return orderby54 = default(MathLangParser.orderby_return);

		object ORDER_BY53_tree=null;

		try { DebugEnterRule(GrammarFileName, "orderby_");
		DebugLocation(104, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:104:9: ( ORDER_BY orderby )
			DebugEnterAlt(1);
			// MathLang.g:104:11: ORDER_BY orderby
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 19);
			ORDER_BY53=(IToken)Match(input,ORDER_BY,Follow._ORDER_BY_in_orderby_979); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ORDER_BY53_tree = (object)adaptor.Create(ORDER_BY53);
			root_0 = (object)adaptor.BecomeRoot(ORDER_BY53_tree, root_0);
			}
			DebugLocation(104, 21);
			PushFollow(Follow._orderby_in_orderby_982);
			orderby54=orderby();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orderby54.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("orderby_", 16);
			LeaveRule("orderby_", 16);
			Leave_orderby_();
			if (state.backtracking > 0) { Memoize(input, 16, orderby__StartIndex); }
		}
		DebugLocation(104, 27);
		} finally { DebugExitRule(GrammarFileName, "orderby_"); }
		return retval;

	}
	// $ANTLR end "orderby_"

	public class where__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_where_();
	partial void Leave_where_();

	// $ANTLR start "where_"
	// MathLang.g:106:1: where_ : WHERE term ;
	[GrammarRule("where_")]
	private MathLangParser.where__return where_()
	{
		Enter_where_();
		EnterRule("where_", 17);
		TraceIn("where_", 17);
		MathLangParser.where__return retval = new MathLangParser.where__return();
		retval.Start = (IToken)input.LT(1);
		int where__StartIndex = input.Index;
		object root_0 = null;

		IToken WHERE55=null;
		MathLangParser.term_return term56 = default(MathLangParser.term_return);

		object WHERE55_tree=null;

		try { DebugEnterRule(GrammarFileName, "where_");
		DebugLocation(106, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:106:7: ( WHERE term )
			DebugEnterAlt(1);
			// MathLang.g:106:9: WHERE term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 14);
			WHERE55=(IToken)Match(input,WHERE,Follow._WHERE_in_where_989); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WHERE55_tree = (object)adaptor.Create(WHERE55);
			root_0 = (object)adaptor.BecomeRoot(WHERE55_tree, root_0);
			}
			DebugLocation(106, 16);
			PushFollow(Follow._term_in_where_992);
			term56=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term56.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("where_", 17);
			LeaveRule("where_", 17);
			Leave_where_();
			if (state.backtracking > 0) { Memoize(input, 17, where__StartIndex); }
		}
		DebugLocation(107, 0);
		} finally { DebugExitRule(GrammarFileName, "where_"); }
		return retval;

	}
	// $ANTLR end "where_"

	public class expr1_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr1();
	partial void Leave_expr1();

	// $ANTLR start "expr1"
	// MathLang.g:109:1: expr1 : select_ from_ expr2 ;
	[GrammarRule("expr1")]
	private MathLangParser.expr1_return expr1()
	{
		Enter_expr1();
		EnterRule("expr1", 18);
		TraceIn("expr1", 18);
		MathLangParser.expr1_return retval = new MathLangParser.expr1_return();
		retval.Start = (IToken)input.LT(1);
		int expr1_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.select__return select_57 = default(MathLangParser.select__return);
		MathLangParser.from__return from_58 = default(MathLangParser.from__return);
		MathLangParser.expr2_return expr259 = default(MathLangParser.expr2_return);


		try { DebugEnterRule(GrammarFileName, "expr1");
		DebugLocation(109, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:109:6: ( select_ from_ expr2 )
			DebugEnterAlt(1);
			// MathLang.g:110:3: select_ from_ expr2
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 3);
			PushFollow(Follow._select__in_expr11002);
			select_57=select_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, select_57.Tree);
			DebugLocation(111, 3);
			PushFollow(Follow._from__in_expr11006);
			from_58=from_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, from_58.Tree);
			DebugLocation(112, 3);
			PushFollow(Follow._expr2_in_expr11010);
			expr259=expr2();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr259.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr1", 18);
			LeaveRule("expr1", 18);
			Leave_expr1();
			if (state.backtracking > 0) { Memoize(input, 18, expr1_StartIndex); }
		}
		DebugLocation(113, 0);
		} finally { DebugExitRule(GrammarFileName, "expr1"); }
		return retval;

	}
	// $ANTLR end "expr1"

	public class expr2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr2();
	partial void Leave_expr2();

	// $ANTLR start "expr2"
	// MathLang.g:115:1: expr2 : ( where_ )? ( orderby_ )? ;
	[GrammarRule("expr2")]
	private MathLangParser.expr2_return expr2()
	{
		Enter_expr2();
		EnterRule("expr2", 19);
		TraceIn("expr2", 19);
		MathLangParser.expr2_return retval = new MathLangParser.expr2_return();
		retval.Start = (IToken)input.LT(1);
		int expr2_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.where__return where_60 = default(MathLangParser.where__return);
		MathLangParser.orderby__return orderby_61 = default(MathLangParser.orderby__return);


		try { DebugEnterRule(GrammarFileName, "expr2");
		DebugLocation(115, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:115:6: ( ( where_ )? ( orderby_ )? )
			DebugEnterAlt(1);
			// MathLang.g:116:3: ( where_ )? ( orderby_ )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(116, 3);
			// MathLang.g:116:3: ( where_ )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==WHERE))
			{
				alt14=1;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: where_
				{
				DebugLocation(116, 3);
				PushFollow(Follow._where__in_expr21020);
				where_60=where_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, where_60.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(14); }

			DebugLocation(117, 3);
			// MathLang.g:117:3: ( orderby_ )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==ORDER_BY))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: orderby_
				{
				DebugLocation(117, 3);
				PushFollow(Follow._orderby__in_expr21025);
				orderby_61=orderby_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orderby_61.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(15); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr2", 19);
			LeaveRule("expr2", 19);
			Leave_expr2();
			if (state.backtracking > 0) { Memoize(input, 19, expr2_StartIndex); }
		}
		DebugLocation(118, 0);
		} finally { DebugExitRule(GrammarFileName, "expr2"); }
		return retval;

	}
	// $ANTLR end "expr2"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:120:1: exprList : ( expr1 ) -> ^( BLOCK expr1 ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 20);
		TraceIn("exprList", 20);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);
		int exprList_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.expr1_return expr162 = default(MathLangParser.expr1_return);

		RewriteRuleSubtreeStream stream_expr1=new RewriteRuleSubtreeStream(adaptor,"rule expr1");
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(120, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:120:9: ( ( expr1 ) -> ^( BLOCK expr1 ) )
			DebugEnterAlt(1);
			// MathLang.g:121:4: ( expr1 )
			{
			DebugLocation(121, 4);
			// MathLang.g:121:4: ( expr1 )
			DebugEnterAlt(1);
			// MathLang.g:121:6: expr1
			{
			DebugLocation(121, 6);
			PushFollow(Follow._expr1_in_exprList1039);
			expr162=expr1();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr1.Add(expr162.Tree);

			}



			{
			// AST REWRITE
			// elements: expr1
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 121:14: -> ^( BLOCK expr1 )
			{
				DebugLocation(121, 17);
				// MathLang.g:121:17: ^( BLOCK expr1 )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(121, 19);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(121, 25);
				adaptor.AddChild(root_1, stream_expr1.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 20);
			LeaveRule("exprList", 20);
			Leave_exprList();
			if (state.backtracking > 0) { Memoize(input, 20, exprList_StartIndex); }
		}
		DebugLocation(122, 0);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class requestList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_requestList();
	partial void Leave_requestList();

	// $ANTLR start "requestList"
	// MathLang.g:124:1: requestList : ( exprList ( ';' ) ) -> ^( REQUEST exprList ) ;
	[GrammarRule("requestList")]
	private MathLangParser.requestList_return requestList()
	{
		Enter_requestList();
		EnterRule("requestList", 21);
		TraceIn("requestList", 21);
		MathLangParser.requestList_return retval = new MathLangParser.requestList_return();
		retval.Start = (IToken)input.LT(1);
		int requestList_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal64=null;
		MathLangParser.exprList_return exprList63 = default(MathLangParser.exprList_return);

		object char_literal64_tree=null;
		RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "requestList");
		DebugLocation(124, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:124:12: ( ( exprList ( ';' ) ) -> ^( REQUEST exprList ) )
			DebugEnterAlt(1);
			// MathLang.g:125:2: ( exprList ( ';' ) )
			{
			DebugLocation(125, 2);
			// MathLang.g:125:2: ( exprList ( ';' ) )
			DebugEnterAlt(1);
			// MathLang.g:125:3: exprList ( ';' )
			{
			DebugLocation(125, 3);
			PushFollow(Follow._exprList_in_requestList1059);
			exprList63=exprList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_exprList.Add(exprList63.Tree);
			DebugLocation(125, 12);
			// MathLang.g:125:12: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:125:13: ';'
			{
			DebugLocation(125, 13);
			char_literal64=(IToken)Match(input,38,Follow._38_in_requestList1062); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_38.Add(char_literal64);


			}


			}



			{
			// AST REWRITE
			// elements: exprList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 125:20: -> ^( REQUEST exprList )
			{
				DebugLocation(125, 23);
				// MathLang.g:125:23: ^( REQUEST exprList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(125, 25);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(REQUEST, "REQUEST"), root_1);

				DebugLocation(125, 33);
				adaptor.AddChild(root_1, stream_exprList.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("requestList", 21);
			LeaveRule("requestList", 21);
			Leave_requestList();
			if (state.backtracking > 0) { Memoize(input, 21, requestList_StartIndex); }
		}
		DebugLocation(126, 0);
		} finally { DebugExitRule(GrammarFileName, "requestList"); }
		return retval;

	}
	// $ANTLR end "requestList"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:128:1: program : requestList ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 22);
		TraceIn("program", 22);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);
		int program_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.requestList_return requestList65 = default(MathLangParser.requestList_return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(128, 22);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:128:8: ( requestList )
			DebugEnterAlt(1);
			// MathLang.g:128:10: requestList
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(128, 10);
			PushFollow(Follow._requestList_in_program1081);
			requestList65=requestList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, requestList65.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 22);
			LeaveRule("program", 22);
			Leave_program();
			if (state.backtracking > 0) { Memoize(input, 22, program_StartIndex); }
		}
		DebugLocation(128, 22);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:130:1: result : program EOF ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 23);
		TraceIn("result", 23);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);
		int result_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF67=null;
		MathLangParser.program_return program66 = default(MathLangParser.program_return);

		object EOF67_tree=null;

		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(130, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:130:7: ( program EOF )
			DebugEnterAlt(1);
			// MathLang.g:130:9: program EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(130, 9);
			PushFollow(Follow._program_in_result1090);
			program66=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program66.Tree);
			DebugLocation(130, 20);
			EOF67=(IToken)Match(input,EOF,Follow._EOF_in_result1092); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 23);
			LeaveRule("result", 23);
			Leave_result();
			if (state.backtracking > 0) { Memoize(input, 23, result_StartIndex); }
		}
		DebugLocation(130, 20);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:132:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 24);
		TraceIn("execute", 24);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);
		int execute_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.result_return result68 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(132, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:132:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:133:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(133, 3);
			PushFollow(Follow._result_in_execute1104);
			result68=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result68.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 24);
			LeaveRule("execute", 24);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 24, execute_StartIndex); }
		}
		DebugLocation(134, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _35_in_group647 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _term_in_group650 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_group652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group657 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TEXT_in_group661 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _table_field_in_group665 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_group670 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _exprList_in_group673 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_group675 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _AS_in_group679 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _FIELD_in_group682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult693 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _set_in_mult697 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _group_in_mult708 = new BitSet(new ulong[]{0xC000002UL});
		public static readonly BitSet _mult_in_add720 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _set_in_add725 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _mult_in_add736 = new BitSet(new ulong[]{0x3000002UL});
		public static readonly BitSet _add_in_compare748 = new BitSet(new ulong[]{0x3F0000002UL});
		public static readonly BitSet _set_in_compare752 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _add_in_compare778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_and789 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _AND_in_and792 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _compare_in_and795 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _and_in_or805 = new BitSet(new ulong[]{0x10002UL});
		public static readonly BitSet _OR_in_or808 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _and_in_or811 = new BitSet(new ulong[]{0x10002UL});
		public static readonly BitSet _or_in_term820 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_table_field828 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DOT_in_table_field830 = new BitSet(new ulong[]{0x4200000UL});
		public static readonly BitSet _set_in_table_field833 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_table_field844 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MUL_in_request_params851 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _table_field_in_request_params855 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _request_params_in_formal_params863 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _37_in_formal_params866 = new BitSet(new ulong[]{0x4200000UL});
		public static readonly BitSet _request_params_in_formal_params868 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _SELECT_in_select_887 = new BitSet(new ulong[]{0x4200000UL});
		public static readonly BitSet _formal_params_in_select_890 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FIELD_in_tables_or_request897 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_tables_or_request902 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _exprList_in_tables_or_request905 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_tables_or_request907 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _AS_in_tables_or_request910 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _FIELD_in_tables_or_request913 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _tables_or_request_in_request_tables921 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _37_in_request_tables924 = new BitSet(new ulong[]{0x800200000UL});
		public static readonly BitSet _tables_or_request_in_request_tables926 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _FROM_in_from_944 = new BitSet(new ulong[]{0x800200000UL});
		public static readonly BitSet _request_tables_in_from_947 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_orderby956 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _37_in_orderby959 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _NUMBER_in_orderby961 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _ORDER_BY_in_orderby_979 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _orderby_in_orderby_982 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHERE_in_where_989 = new BitSet(new ulong[]{0x800700000UL});
		public static readonly BitSet _term_in_where_992 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _select__in_expr11002 = new BitSet(new ulong[]{0x20UL});
		public static readonly BitSet _from__in_expr11006 = new BitSet(new ulong[]{0xC0UL});
		public static readonly BitSet _expr2_in_expr11010 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _where__in_expr21020 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _orderby__in_expr21025 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr1_in_exprList1039 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _exprList_in_requestList1059 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_requestList1062 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _requestList_in_program1081 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result1090 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1104 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
