using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epic_2._0
{
    public partial class Form9: Form
    {
        public Form9()
        {
            InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{
				axWindowsMediaPlayer1.Ctlcontrols.stop();
			}
			axWindowsMediaPlayer1.close();

			System.Runtime.InteropServices.Marshal.ReleaseComObject(axWindowsMediaPlayer1);
			axWindowsMediaPlayer1 = null;

			foreach (var process in Process.GetProcessesByName("epic 2.0"))
			{
				try { process.Kill(); }
				catch { /* Ignora exceções */ }
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{

			this.Close();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
			string caminho = @"C:\Users\DB\Desktop\epic videos\Not Sorry for Loving You.mp4"; // Troque pelo nome real

			if (System.IO.File.Exists(caminho))
			{
				axWindowsMediaPlayer1.URL = caminho;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			else
			{
				MessageBox.Show("Arquivo não encontrado! Verifique o caminho.");
			}
			textBox1.Multiline = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Text = "Não Sinto Por Amar Você (part. Barbara Wangui)\r\nNot Sorry For Loving You (feat. Barbara Wangui)\r\n\r\n[Calypso]\r\n[Calypso]\r\n\r\nAlguém chegou hoje\r\nSomeone arrived today\r\n\r\nEles disseram que vão te levar embora\r\nThey said they're taking you away\r\n\r\nQue você não é meu para salvar\r\nThat you're not mine to save\r\n\r\nE logo não poderei mais ver seu rosto\r\nAnd soon I won't get to see your face\r\n\r\nEntão eu vim aqui para dizer\r\nSo I came by to say\r\n\r\nVocê é diferente de qualquer pessoa que eu já conheci\r\nYou're unlike anyone I have ever known\r\n\r\nPorque você é tudo que eu já conheci\r\nCause you're all I've ever known\r\n\r\n\r\nE se eu te empurrasse\r\nAnd if I pushed you\r\n\r\nOu se eu fui muito forte\r\nOr if I came on too strong\r\n\r\nOu se eu te emboscasse\r\nOr if I ambushed you\r\n\r\nPor isso direi que estava errado\r\nFor that, I'll say I was wrong\r\n\r\nE se você me odeia\r\nAnd if you hate me\r\n\r\nEntão me desculpe, meu amor é demais para você\r\nThen I am sorry my love's too much for you\r\n\r\nMas não me arrependo de te amar\r\nBut I'm not sorry for loving you\r\n\r\n\r\n[Calypso]\r\n[Calypso]\r\n\r\nNão me arrependo de te amar\r\nI'm not sorry for loving you\r\n\r\n(Não me arrependo de te amar)\r\n(I'm not sorry for loving you)\r\n\r\nNão me arrependo de te amar\r\nI'm not sorry for loving you\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nCalypso\r\nCalypso\r\n\r\n\r\n[Calypso, coro]\r\n[Calypso]\r\n\r\nDeixe-me falar\r\nLet me speak\r\n\r\nPassei minha vida inteira aqui\r\nI spent my whole life here\r\n\r\nFoi rejeitado quando eu era jovem\r\nWas cast away when I was young\r\n\r\nSozinho por cem anos\r\nAlone for a hundred years\r\n\r\nEu não tinha amigos além do céu e do Sol\r\nI had no friends but the sky and Sun\r\n\r\nEntão quando você foi levado para a praia\r\nSo when you washed ashore\r\n\r\nEu tinha certeza de que você era meu sonho realizado\r\nI thought for sure that you were my dream come true\r\n\r\nEu pensei que sabia\r\nI thought I knew\r\n\r\n\r\nEntão se eu te empurrasse\r\nSo if I pushed (you)\r\n\r\nOu se eu fui muito (forte)\r\nOr if I came on too (strong)\r\n\r\nOu se eu te emboscasse\r\nOr if I ambushed (you)\r\n\r\nPor isso eu direi (eu estava errado)\r\nFor that, I'll say (I was wrong)\r\n\r\nE se você me odeia\r\nAnd if you hate (me)\r\n\r\nEntão me desculpe, meu amor é demais para você\r\nThen I am sorry my love's too much for you\r\n\r\n\r\n[Calypso, coro]\r\n[Calypso]\r\n\r\nMas não me arrependo de te amar\r\nBut I'm not sorry for loving you\r\n\r\n(Não me arrependo de te amar)\r\n(I'm not sorry for loving you)\r\n\r\nNão me arrependo de te amar\r\nI'm not sorry for loving you\r\n\r\n(Não me arrependo de te amar)\r\n(I'm not sorry for loving you)\r\n\r\n\r\n[Calypso]\r\n[Calypso]\r\n\r\nEu não sinto muito\r\nI'm not sorry\r\n\r\nEstou com raiva, cansado, inquieto e triste\r\nI'm angry and tired and restless and sad\r\n\r\nEstou preso nos momentos que jurei que tínhamos\r\nI'm stuck in the moments I swore that we had\r\n\r\nEu queria que você me perseguisse\r\nI wish you would chase me\r\n\r\nOu tente me abraçar\r\nOr try to embrace me\r\n\r\nPor uma vez, eu queria que você mentisse e dissesse\r\nFor once, I wish you would lie and say\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEu te amo\r\nI love you\r\n\r\n\r\n[Calypso]\r\n[Calypso]\r\n\r\nAma?\r\nYou do?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nMas não do jeito que você quer que eu ame\r\nBut not in the way that you want me to\r\n\r\n\r\n[Calypso, coro]\r\n[Calypso]\r\n\r\nEu odeio ter me apaixonado por você\r\nI hate that I fell in love with you\r\n\r\n(Odeio ter me apaixonado por você)\r\n(Hate that I fell in love with you)\r\n\r\nPor que me apaixonei por você?\r\nWhy did I fall in love with you?\r\n\r\n(Por que me apaixonei por você?)\r\n(Why did I fall in love with you?)\r\n\r\nO que eu faço com esse amor por você?\r\nWhat do I do with this love for you?\r\n\r\n(O que eu faço com esse amor por você?)\r\n(What do I do with this love for you?)\r\n\r\nComo vou superar você?\r\nHow am I supposed to get over you?\r\n\r\n(Como vou superar você?)\r\n(How am I supposed to get over you?)\r\n\r\nPor que diabos você não me ama também?\r\nWhy in the world won't you love me too?";

		}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
			string caminho = @"C:\Users\DB\Desktop\epic videos\Dangerous.mp4"; // Troque pelo nome real

			if (System.IO.File.Exists(caminho))
			{
				axWindowsMediaPlayer1.URL = caminho;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			else
			{
				MessageBox.Show("Arquivo não encontrado! Verifique o caminho.");
			}
			textBox1.Multiline = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Text = "Perigoso (part. Troy Doherty)\r\nDangerous (feat. Troy Doherty)\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nSeiscentos homens\r\nSix hundred men\r\n\r\nSeiscentos mortos sob meu comando\r\nSix hundred deaths under my command\r\n\r\nPorque eu tinha um objetivo em mente\r\n'Cause I had one goal in mind\r\n\r\nSem frota, sem tripulaçao\r\nNo fleet, no band\r\n\r\nSó essa jangada que eu fiz a mão\r\nOnly this raft that I made by hand\r\n\r\nComo chegarei à minha terra Natal?\r\nHow will I reach my homeland?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nTudo o que você precisa fazer é não abrir esta bolsa\r\nAll you have to do is not open this bag\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nHermes?\r\nHermes?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nAhahahahaha, olá velho amigo\r\nHa-ha-ha-ha! Hello, old friend\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEntão foi você quem falou com Calypso?\r\nSo you're the one who talked to Calypso?\r\n\r\nPor que você está aqui?\r\nWhy are you here?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nVocê está recebendo uma opção final\r\nYou're being given a final option\r\n\r\nConsidere esta sua última chance\r\nConsider this your one last chance\r\n\r\nPara voltar para casa e abandonar a cautela\r\nTo make it back home and abandon caution\r\n\r\nLave-o como o sangue que suas mãos conheceram\r\nWash it away like the blood your hands have known\r\n\r\nEu sei que se você dançar com o destino\r\nI know if you dance with fate\r\n\r\nEntão eu sei, eu sei que você vai melhorar seu estado\r\nThen I know, I know you'll enhance your state\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nSe seu plano é tão bom, por que você esperou para dizê-lo?\r\nIf your plan's so great, then why'd you wait to say it?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nBem, é um pouco perigoso, meu amigo\r\nWell, it's a little bit dangerous, my friend\r\n\r\nVocê precisará de uma mudança de mentalidade para isso\r\nYou'll need a mindset change for this\r\n\r\nVocê não pode escapar jogando pelo seguro por isso\r\nYou cannot get away with playing safe for this\r\n\r\nVocê quer ir para casa? Coloque tudo em risco\r\nYou wanna get home? Put it all on the line\r\n\r\nE coloque todo o seu cérebro nisso\r\nAnd put your whole brain in it\r\n\r\nLembre-se de todos os truques do seu domínio para isso\r\nRemember every trick in your domain for this\r\n\r\nVocê tem que tratar isso como se fosse o evento principal\r\nYou gotta treat it like it is the main event\r\n\r\nVocê quer ir para casa? Coloque tudo em risco\r\nYou wanna get home? Put it all on the line\r\n\r\nSeja perigoso\r\nBe dangerous\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nCerto, estou dentro, o que eu faço?\r\nAlright, I'm in, what do I do?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nPrimeira parada, águas desconhecidas\r\nFirst stop, uncharted waters\r\n\r\nQuando estiver perdido, olhe para o céu\r\nWhen lost, look towards the sky\r\n\r\nSiga a estrela do norte, não importa o quão longe\r\nFollow the north star, no matter how far\r\n\r\nVocê acha que está indo, você continua remando\r\nYou think you're going, you keep on rowing\r\n\r\nQuando estranhos espreitam pela ilha\r\nWhen strangers lurk around the isle\r\n\r\nQuando o perigo te cumprimenta com um sorriso\r\nWhen danger greets you with a smile\r\n\r\nLute para passar, faça o que você deve fazer\r\nFight your way through, do what you must do\r\n\r\nMas não importa o que aconteça, continue andando\r\nBut no matter what, keep moving\r\n\r\n\r\nVai ser perigoso, meu amigo\r\nIt's gonna be dangerous, my friend\r\n\r\nVocê precisará de uma mudança de mentalidade para isso\r\nYou'll need a mindset change for this\r\n\r\nVocê não pode escapar jogando pelo seguro por isso\r\nYou cannot get away with playing safe for this\r\n\r\nVocê quer ir para casa? Coloque tudo em risco\r\nYou wanna get home? Put it all on the line\r\n\r\nE coloque todo o seu cérebro nisso\r\nAnd put your whole brain in it\r\n\r\nLembre-se de todos os truques do seu domínio para isso\r\nRemember every trick in your domain for this\r\n\r\nVocê tem que tratar isso como se fosse o evento principal\r\nYou gotta treat it like it is the main event\r\n\r\nVocê quer ir para casa? Coloque tudo em risco\r\nYou wanna get home? Put it all on the line\r\n\r\nSeja perigoso\r\nBe dangerous\r\n\r\n\r\n[Hermes e Winions]\r\n[Hermes and Winions]\r\n\r\nE por último, o saco de vento\r\nAnd lastly, the wind bag\r\n\r\nPassamos por muita coisa para conseguir isso\r\nWe went through so much to get this\r\n\r\nMantenha esta bolsa fechada se quiser ir para casa, senhor\r\nKeep this bag closed if you wanna get home, sir\r\n\r\n(Você não terá outra chance de tentar)\r\n(You won't get another time to try)\r\n\r\nA tempestade furiosa dentro de você não vai deixar você se aproximar\r\nThe raging storm inside won't let you get closer\r\n\r\n(Foi feito para te parar por design)\r\n(It was meant to stop you by design)\r\n\r\nPorque nenhum mortal pode passar pela tempestade de Poseidon\r\n'Cause no mortal can pass Poseidon's storm\r\n\r\nAbra esta bolsa e você nunca mais voltará para casa\r\nOpen this bag, and you'll never make it home\r\n\r\nVocê nunca chegará em casa\r\nYou'll never make it home\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê não sabe que o perigo é meu amigo?\r\nDon't you know that danger is my friend?\r\n\r\nDurante toda a minha vida treinei para isso\r\nMy whole life, I've trained for this\r\n\r\nNão posso dizer quanto paguei por isso\r\nI cannot tell you how much I have paid for this\r\n\r\nTenho que ir para casa, arriscar tudo\r\nI have to get home, put it all on the line\r\n\r\nVou usar a crueldade\r\nI'm gonna use ruthlessness\r\n\r\nCada truque, cada habilidade colocada em uso para isso\r\nEvery trick, every skill put to use for this\r\n\r\nPretendo acabar com toda essa tolice\r\nI plan to put an end to all the foolishness\r\n\r\nTenho que ir para casa, arriscar tudo\r\nI have to get home, put it all on the line\r\n\r\nEu serei perigoso\r\nI'll be dangerous\r\n\r\n\r\n[Odisseu]\r\n[Odysseys]\r\n\r\nHermes!\r\nHermes!\r\n\r\nObrigado\r\nThank you\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nNão me agradeça, amigo\r\nDon't thank me, friend\r\n\r\nNão fui eu quem lutou por você\r\nI'm not the one who fought for you\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEntão quem?\r\nThen who?\r\n\r\n\r\n[Hermes]\r\n[Hermes]\r\n\r\nHaha! Boa sorte\r\nHa-ha! Good luck\r\n";

		}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
			string caminho = @"C:\Users\DB\Desktop\epic videos\Charybdis.mp4"; // Troque pelo nome real

			if (System.IO.File.Exists(caminho))
			{
				axWindowsMediaPlayer1.URL = caminho;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			else
			{
				MessageBox.Show("Arquivo não encontrado! Verifique o caminho.");
			}
			textBox1.Multiline = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Text = "Caríbdis\r\nCharybdis\r\n\r\n[ODISSEU]\r\n[ODYSSEUS]\r\n\r\nVocê deve ser quem Hermes mencionou\r\nYou must be who Hermes mentioned\r\n\r\nUm monstro aqui para bloquear meu caminho\r\nA monster here to block my way\r\n\r\nEu gostaria de me apressar e acabar com isso\r\nI'd like to hurry up and end this\r\n\r\nEntão, se você não tem muito a dizer\r\nSo if you don't have much to say\r\n\r\n\r\nEntão, manda ver\r\nThen oh, bring it on\r\n\r\nNão vou morrer aqui, ainda estou lutando\r\nI'm not dying here, I'm still fighting here\r\n\r\nEstou resistindo\r\nI'm holding on\r\n\r\nAté que eu supere isso, até que eu tenha vencido você\r\nTill I see it through, till I've beaten you\r\n\r\n\r\n[ODISSEU]\r\n[ODYSSEUS]\r\n\r\nEu já conheço suas táticas\r\nI already know your tactics\r\n\r\nQuando você engole, ataca com redemoinhos que atraem a presa\r\nWhen you swallow you attack with whirlpools that attract prey\r\n\r\nMas eu vejo uma desvantagem, porque eu nem preciso te matar\r\nBut I see a disadvantage, 'cause I don't even have to kill you\r\n\r\nSó preciso evitar você\r\nI just have to avoid you\r\n\r\nVeja, se você não cuspir logo, toda essa água vai te destruir\r\nSee, if you don't spit it out soon, all that water will destroy you\r\n\r\n\r\nOh, manda ver\r\nOh, bring it on\r\n\r\nAté que você fique sem fôlego, até que não reste mais nada\r\nTill you're out of breath, till there's nothing left\r\n\r\nEstou resistindo\r\nI'm holding on\r\n\r\nAté que eu esteja livre, até que eu esteja fora daqui, oh\r\nTill I'm in the clear, till I'm out of here, oh\r\n\r\n\r\n[ODISSEU]\r\n[ODYSSEUS]\r\n\r\nLá, estou vendo\r\nThere, I see it\r\n\r\nA ilha que eu estive procurando\r\nThe island I've been searching for\r\n\r\nLar, eu cheguei\r\nHome, I've reached it\r\n\r\nMinha esposa e meu filho estão além destas margens\r\nMy wife and son are past these shores\r\n\r\nResistindo\r\nHolding on\r\n\r\nEstou quase lá\r\nI am almost there\r\n\r\nMeu amor, não tenha medo\r\nMy love, don't be scared\r\n\r\nAguarde\r\nHold on\r\n\r\nEstou a caminho\r\nI am on my way\r\n\r\nEstarei lá hoje\r\nI'll be there today\r\n\r\nPenélope\r\nPenelope\r\n\r\n\r\n[ODISSEU]\r\n[ODYSSEUS]\r\n\r\nO quê?\r\nWhat?\r\n\r\nNão\r\nNo\r\n\r\nNão!\r\nNo!\r\n";

		}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

			string caminho = @"C:\Users\DB\Desktop\epic videos\Get in the Water.mp4"; // Troque pelo nome real

			if (System.IO.File.Exists(caminho))
			{
				axWindowsMediaPlayer1.URL = caminho;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			else
			{
				MessageBox.Show("Arquivo não encontrado! Verifique o caminho.");
			}
			textBox1.Multiline = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Text = "Entre na Água (part. Steven Rodriguez)\r\nGet in the Water (feat. Steven Rodriguez)\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nAí está você\r\nThere you are\r\n\r\nCovarde\r\nCoward\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nEu estava esperando por esse momento\r\nI've been waiting for this moment\r\n\r\nPara o momento perfeito para atacar\r\nFor the perfect time to strike\r\n\r\nQuando sua casa está tão perto\r\nWhen your home's so close\r\n\r\nE você chegou à sua costa\r\nAnd you've reached your coast\r\n\r\nÉ quando nossos caminhos se cruzam\r\nThat's when our paths collide\r\n\r\nEu tenho uma reputação\r\nI've got a reputation\r\n\r\nEu tenho um nome a defender\r\nI've got a name to uphold\r\n\r\nEntão não posso deixar você ir embora ou então o mundo esquece que sou frio\r\nSo I can't go letting you walk or else the world forgets I'm cold\r\n\r\n\r\nAgora entre na água\r\nNow get in the water\r\n\r\nEntre na água\r\nGet in the water\r\n\r\nOu eu vou elevar a maré tão alto que toda Ítaca vai morrer\r\nOr I'll raise the tide so high, all of Ithaca will die\r\n\r\nEntre na água\r\nGet in the water\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEspere\r\nWait\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nEntre na água\r\nGet in the water\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nPare com isso, por favor\r\nStop this, please\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nEu farei ondas gigantescas tão profundas\r\nI'll make tidal waves so profound\r\n\r\nTanto sua esposa quanto seu filho se afogarão\r\nBoth your wife and your son will drown\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nNão!\r\nNo!\r\n\r\n\r\n[Poseidon e conjunto]\r\n[Poseidon e ensemble]\r\n\r\nEntre na água\r\nGet in the water\r\n\r\n(Entre na água)\r\n(Get in the water)\r\n\r\nNão confunda minhas ameaças com blefe\r\nDon't mistake my threats for bluff\r\n\r\nVocê viveu mais do que o suficiente\r\nYou have lived more than enough\r\n\r\nEntre na água\r\nGet in the water\r\n\r\n(Entre na água)\r\n(Get in the water)\r\n\r\nVou pegar seu filho e arrancar os olhos dele\r\nI'll take your son and gouge his eyes\r\n\r\nIsto é, a menos que você escolha morrer\r\nThat is, unless you choose to die\r\n\r\n(Entre na água)\r\n(Get in the water)\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê não está cansado, Poseidon?\r\nAren't you tired, Poseidon?\r\n\r\nJá se passaram dez anos, quanto tempo isso vai durar?\r\nIt's been ten years, how long will this go?\r\n\r\nNós dois estamos sofrendo com as perdas\r\nWe're both hurting from losses\r\n\r\nEntão por que não deixar isso aqui e ir para casa?\r\nSo why not leave this here and just go home?\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nNão posso\r\nI can't\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nTalvez você possa aprender a perdoar?\r\nMaybe you could learn to forgive?\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nNão\r\nNo\r\n\r\nCrueldade é\r\nRuthlessness is\r\n\r\nMisericórdia sobre\r\nMercy upon\r\n\r\nNós mesmos\r\nOurselves\r\n\r\nMorra!\r\nDie!\r\n\r\n\r\n[Políticas, Euríloco, Anticlea e todos]\r\n[Polities, Eurylochus, Anticlea and all]\r\n\r\nPode relaxar meu amigo\r\nYou can relax my friend\r\n\r\nPodemos dizer que você está ficando nervoso\r\nWe can tell you're getting nervous\r\n\r\nOlhe para tudo o que perdemos e tudo o que aprendemos\r\nLook at all we've lost and all we've learned\r\n\r\nEu ficarei em seu coração\r\nI'll stay in your heart\r\n\r\nOh, uau, Odisseu\r\nOh, woah, Odysseus\r\n\r\nEsperando, esperando\r\nWaiting, waiting\r\n\r\nOh\r\nOh\r\n";

		}

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
			string caminho = @"C:\Users\DB\Desktop\epic videos\Six Hundred Strike.mp4"; // Troque pelo nome real

			if (System.IO.File.Exists(caminho))
			{
				axWindowsMediaPlayer1.URL = caminho;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			else
			{
				MessageBox.Show("Arquivo não encontrado! Verifique o caminho.");
			}
			textBox1.Multiline = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Text = "Greve dos Seiscentos\r\nSix Hundred Strike\r\n\r\n[Coro]\r\n[Ensemble]\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nAcho que você não entendeu\r\nI don't think you seem to get it\r\n\r\nNão posso me dar ao luxo de morrer\r\nI can't afford to die\r\n\r\nPorque eu voltarei para meu filho\r\n'Cause I will get back to my son\r\n\r\nE eu voltarei para minha esposa\r\nAnd I will get back to my wife\r\n\r\n\r\nPara cada camarada\r\nFor every comrade\r\n\r\nCada um dos meus amigos\r\nEvery one of my friends\r\n\r\nQuase todos foram massacrados por suas mãos\r\nAlmost all of whom were slaughtered by your hand\r\n\r\nGreve dos seiscentos\r\nSix hundred strike\r\n\r\n\r\n[Coro]\r\n[Ensemble]\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos homens, seiscentos\r\nSix hundred men, six hundred\r\n\r\nSeiscentos, seiscentos homens\r\nSix hundred, six hundred men\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nSeu idiota\r\nYou idiot\r\n\r\nVocê não consegue ver\r\nCan't you see\r\n\r\nVocê selou seu destino\r\nYou sealed your fate\r\n\r\nSó para me vencer\r\nJust to beat me\r\n\r\nVocê libertou minha tempestade\r\nYou released my storm\r\n\r\nQuando você abriu aquela bolsa\r\nWhen you opened that bag\r\n\r\nBloqueou seu caminho para casa agora você nunca mais vai voltar\r\nBlocked your one way home now you'll never get back\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê vai cancelar essa tempestade\r\nYou're going to call off that storm\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nOu o quê?\r\nOr what?\r\n\r\nVocê não pode me matar\r\nYou can't kill me\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nExatamente\r\nExactly\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nEspere\r\nWait\r\n\r\nEspere\r\nWait\r\n\r\nAh\r\nAh\r\n\r\n\r\n[Odisseu e Poseidon]\r\n[Odysseus and Poseidon]\r\n\r\nComo é ser desamparado? (Argh)\r\nHow does it feel to be helpless? (Argh)\r\n\r\nComo é conhecer a dor? (Ugh)\r\nHow does it feel to know pain? (Ugh)\r\n\r\nEu vi meus amigos morrerem de horror (ah)\r\nI watched my friends die in horror (ah)\r\n\r\nChorando enquanto todos eram mortos (ugh)\r\nCrying as they were all slain (ugh)\r\n\r\nEu ouvi os últimos momentos deles (argh)\r\nI heard their final moments (argh)\r\n\r\nChamando seu capitão em vão (ugh)\r\nCalling their captain in vain (ugh)\r\n\r\nOlha no que você me transformou (ah)\r\nLook what you turned me into (ah)\r\n\r\nOlha no que nos tornamos (ugh)\r\nLook what we've become (ugh)\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nSuficiente\r\nEnough\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nToda a dor que passei\r\nAll of the pain that I've been through\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nParar\r\nStop\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEu já não sofri o suficiente?\r\nHaven't I suffered enough?\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nParar\r\nStop\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê não parou quando eu implorei\r\nYou didn't stop when I begged you\r\n\r\nMe disse para fechar meu coração\r\nTold me to close my heart\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nVocê\r\nYou\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê disse que o mundo era escuro\r\nYou said the world was dark\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nMonstro\r\nMonster\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVocê não disse que a implacável é misericórdia para com nossos-\r\nDidn't you say that ruthlessness is mercy upon our-\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nTudo bem\r\nAlright\r\n\r\nPor favor\r\nPlease\r\n\r\n\r\n[Poseidon]\r\n[Poseidon]\r\n\r\nDepois de tudo que você fez\r\nAfter everything you've done\r\n\r\nComo você vai dormir à noite?\r\nHow will you sleep at night?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nAo lado da minha esposa\r\nNext to my wife\r\n\r\n\r\n";

		}
    }
}
