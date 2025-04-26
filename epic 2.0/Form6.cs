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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Encerra o player completamente
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            axWindowsMediaPlayer1.close();

            // Força a liberação de recursos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(axWindowsMediaPlayer1);
            axWindowsMediaPlayer1 = null;

            // Mata o processo específico
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
            string caminho = @"C:\Users\DB\Desktop\epic videos\the underworld.mp4"; // Troque pelo nome real

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
            textBox1.Text = "O submundo\r\nThe Underworld\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nAmigos, as instruções de Circe eram claras\r\nFriends, circe's instructions were clear\r\n\r\nNão importa o que ouvimos\r\nNo matter what we hear\r\n\r\n\r\n[Tripulação]\r\n[Crew]\r\n\r\nÀ toda velocidade\r\nFull speed ahead\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nAté encontrarmos o profeta\r\nUntil we find the prophet\r\n\r\nMeus camaradas, esta terra confunde sua mente\r\nMy comrades, this land confuses your mind\r\n\r\nEntão não importa quem encontramos\r\nSo no matter who we find\r\n\r\n\r\n[Todos]\r\n[All]\r\n\r\nÀ toda velocidade\r\nFull speed ahead\r\n\r\nAté encontrarmos o profeta\r\nUntil we find the prophet\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nBom\r\nGood\r\n\r\n\r\n[Odisseu e soldados]\r\n[Odysseus and soldiers]\r\n\r\nTudo que ouço são gritos\r\nAll I hear are screams\r\n\r\nToda vez que ouso fechar meus olhos\r\nEvery time I dare to close my eyes\r\n\r\nEu não sonho mais\r\nI no longer dream\r\n\r\nApenas pesadelos daqueles que morreram\r\nOnly nightmares of those who've died\r\n\r\nNada é o que parece\r\nNothing's what it seems\r\n\r\n(Nada é o que parece)\r\n(Nothing's what it seems)\r\n\r\nE aqui no submundo\r\nAnd here in the underworld\r\n\r\nO passado parece estar próximo\r\nThe past seems close behind\r\n\r\nEsta terra confunde sua mente\r\nThis land confuses your mind\r\n\r\n\r\n[Soldados caídos]\r\n[Fallen soldiers]\r\n\r\nQuando um homem se torna um monstro?\r\nWhen does a man become a monster?\r\n\r\n558 homens que morreram sob seu comando\r\n558 men who died under your command\r\n\r\nCapitão! Capitão! Capitão! Capitão!\r\nCaptain! Captain! Captain! Captain!\r\n\r\nPor que você deixaria o ciclope viver\r\nWhy would you let the cyclops live\r\n\r\nQuando a crueldade é misericórdia?\r\nWhen ruthlessness is mercy?\r\n\r\n\r\n[Odisseu e soldados]\r\n[Odysseus and soldiers]\r\n\r\nTudo que ouço são gritos\r\nAll I hear are screams\r\n\r\nToda vez que ouso fechar meus olhos\r\nEvery time I dare to close my eyes\r\n\r\nEu não sonho mais\r\nI no longer dream\r\n\r\nApenas pesadelos daqueles que morreram\r\nOnly nightmares of those who've died\r\n\r\nNada é o que parece\r\nNothing's what it seems\r\n\r\n(Nada é o que parece)\r\n(Nothing's what it seems)\r\n\r\nMas no submundo\r\nBut in the underworld\r\n\r\nO passado parece estar próximo\r\nThe past seems close behind\r\n\r\nContinuo pensando na criança daquela noite\r\nI keep thinking of the infant from that night\r\n\r\nContinuo pensando na criança daquela noite\r\nI keep thinking of the infant from that night\r\n\r\n\r\n[Polites]\r\n[Polites]\r\n\r\nEsta vida é incrível quando você a recebe de braços abertos\r\nThis life is amazing when you greet it with open arms\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nPolites\r\nPolites\r\n\r\n\r\n[Polites]\r\n[Polites]\r\n\r\nNão importa o que enfrentemos, ficaremos bem se estivermos liderando com o coração\r\nWhatever we face, we'll be fine if we're leading from the heart\r\n\r\nNão importa o lugar, podemos iluminar o mundo\r\nNo matter the place, we can light up the world\r\n\r\nVeja como começar\r\nHere's how to start\r\n\r\nReceba o mundo de braços abertos\r\nGreet the world with open arms\r\n\r\nReceba o mundo de braços abertos\r\nGreet the world with open arms\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nPolites\r\nPolites\r\n\r\n\r\n[Anticléia]\r\n[Anticlea]\r\n\r\nEsperando\r\nWaiting\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEssa voz, não pode ser\r\nThat voice, it can't be\r\n\r\n\r\n[Anticlea e Odisseu]\r\n[Anticlea and Odysseus]\r\n\r\nEsperando (mãe?)\r\nWaiting (mom?)\r\n\r\nOdisseu, quando você voltar para casa eu estarei esperando\r\nOdysseus, when you come home I'll be waiting\r\n\r\nMesmo que você seja a última coisa que eu veja, estarei esperando\r\nEven if you're the last thing I see, I'll be waiting\r\n\r\nEstou aqui, mãe\r\nI'm right here, mom\r\n\r\n(Esperando)\r\n(Waiting)\r\n\r\nVocê não consegue ver? Eu estou\r\nCan't you see? I'm\r\n\r\n(Esperando)\r\n(Waiting)\r\n\r\n\r\n[Ambos]\r\n[Both]\r\n\r\nEsperando\r\nWaiting\r\n\r\n\r\n[Odisseu e Anticlea]\r\n[Odysseus and Anticlea]\r\n\r\nDemorei muito\r\nI took too long\r\n\r\n(Eu sempre te amarei)\r\n(I'll always love you)\r\n\r\nE se aventurou longe demais\r\nAnd ventured too far\r\n\r\n(Eu ficarei em seu coração)\r\n(I'll stay in your heart)\r\n\r\nEnquanto você estava\r\nWhile you were\r\n\r\n\r\n[Ambos]\r\n[Both]\r\n\r\nEsperando, esperando, esperando\r\nWaiting, waiting, waiting\r\n\r\n\r\n[Odisseu]\r\n[Odyssues]\r\n\r\nTchau mãe\r\nBye mom\r\n\r\n\r\n[Odisseu e soldados]\r\n[Odysseus and soldiers]\r\n\r\nTudo que ouço são gritos\r\nAll I hear are screams\r\n\r\n(Tudo o que ouço são gritos)\r\n(All I hear are screams)\r\n\r\nToda vez que ouso fechar meus olhos\r\nEvery time I dare to close my eyes\r\n\r\nEu não sonho mais\r\nI no longer dream\r\n\r\n(Eu não sonho mais)\r\n(I no longer dream)\r\n\r\nApenas pesadelos daqueles que morreram\r\nOnly nightmares of those who've died\r\n\r\nNada é o que parece\r\nNothing's what it seems\r\n\r\n(Nada é o que parece)\r\n(Nothing's what it seems)\r\n\r\nMas no submundo, seu passado está sempre por perto\r\nBut in the underworld, your past is always close behind\r\n\r\nSeu passado está sempre por perto\r\nYour past is always close behind\r\n\r\nLá no submundo\r\nDown in the underworld\r\n";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\DB\Desktop\epic videos\no longer you.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Não É Mais Você\r\nNo Longer You\r\n[Tiresias]\r\n[Tiresias]\r\n\r\nEu sou o profeta com as respostas que você busca\r\nI am the prophet with the answers you seek\r\n\r\nTempo, eu o desvendei\r\nTime, I've unlocked it\r\n\r\nVejo passado e futuro correndo livres\r\nI see past and future running free\r\n\r\nExiste um mundo onde eu te ajudo a voltar para casa\r\nThere is a world where I help you get home\r\n\r\nMas esse não é o mundo que eu conheço\r\nBut that's not a world I know\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nO quê?\r\nWhat?\r\n\r\n\r\n[Tiresias]\r\n[Tiresias]\r\n\r\nEu vejo uma canção de um romance passado\r\nI see a song of past romance\r\n\r\nVejo o sacrifício de homens\r\nI see the sacrifice of men\r\n\r\nVejo retratos de traições\r\nI see portrayals of betrayals\r\n\r\nE a última resistência de um irmão\r\nAnd a brother's final stand\r\n\r\nVejo você à beira da morte\r\nI see you on the brink of death\r\n\r\nVejo você dar seu último suspiro\r\nI see you draw your final breath\r\n\r\nVejo um homem que consegue voltar para casa vivo\r\nI see a man who gets to make it home alive\r\n\r\nMas não é mais você\r\nBut it's no longer you\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nNão pode ser\r\nThis can't be\r\n\r\nNós sofremos e navegamos pelos piores infernos\r\nWe've suffered and sailed through the toughest of hells\r\n\r\nAgora você nos diz que nosso esforço foi em vão?!\r\nNow you tell us our effort's for nothing?\r\n\r\n\r\n[Tiresias]\r\n[Tiresias]\r\n\r\nEu vejo seu palácio coberto de vermelho\r\nI see your palace covered in red\r\n\r\nRostos de homens que há muito acreditam que você está morto\r\nFaces of men who had long believed you're dead\r\n\r\nVejo sua esposa com um homem que está assombrado\r\nI see your wife with a man who is haunting\r\n\r\nUm homem com um rastro de corpos\r\nA man with a trail of bodies\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nQuem?!\r\nWho?\r\n\r\n\r\n[Tiresias, coro]\r\n[Tiresias]\r\n\r\nEu vejo uma canção de um romance passado\r\nI see a song of past romance\r\n\r\nVejo o sacrifício de homens\r\nI see the sacrifice of men\r\n\r\nVejo retratos de traições\r\nI see portrayals of betrayals\r\n\r\nE a última resistência de um irmão\r\nAnd a brother's final stand\r\n\r\nVejo você à beira da morte (canção das sereias, harganta de cila)\r\nI see you on the brink of death (siren song, scylla throat)\r\n\r\nVejo você dar seu último suspiro (motim, raio-mestre)\r\nI see you draw your final breath (mutiny, lightning bolt)\r\n\r\nVejo um homem que consegue voltar para casa vivo (fira Poseidon, mate todos os pretendentes por amor)\r\nI see a man who gets to make it home alive (hurt Poseidon, kill all the suitors for love)\r\n\r\nMas não é mais você\r\nBut it's no longer you\r\n\r\n\r\n[Coro]\r\n[All]\r\n\r\nO-dis-se-u!\r\nO-dy-sse-us!\r\n\r\nO-dis-se-u!\r\nO-dy-sse-us!\r\n";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\DB\Desktop\epic videos\monster.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Monstro\r\nMonster\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nComo tudo se voltou contra nós?\r\nHow has everything been turned against us?\r\n\r\nComo o sofrimento se tornou tão interminável?\r\nHow did suffering become so endless?\r\n\r\nComo posso me reunir com meus amados?\r\nHow am I to reunite with my estranged?\r\n\r\nEu preciso mudar?\r\nDo I need to change?\r\n\r\n\r\nEstou cercado pelas almas daqueles que perdi\r\nI'm surrounded by the souls of those I've lost\r\n\r\nEu sou o único cuja linha não cruzei\r\nI'm the only one whose line I haven't crossed\r\n\r\nE se a maior ameaça que encontrarmos no mar\r\nWhat if the greatest threat we'll find across the sea\r\n\r\nSou eu?\r\nIs me?\r\n\r\n\r\nE se eu for o monstro?\r\nWhat if I'm the monster?\r\n\r\nE se eu estiver errado?\r\nWhat if I'm in the wrong?\r\n\r\nE se eu for o problema que esteve escondido o tempo todo?\r\nWhat if I'm the problem that's been hiding all along?\r\n\r\nE se fui eu que matou vocês\r\nWhat if I'm the one who killed you\r\n\r\nToda vez que cedi à culpa?\r\nEvery time I caved to guilt?\r\n\r\nE se eu tiver sido muito gentil com os inimigos\r\nWhat if I've been far too kind to foes\r\n\r\nMas um monstro para nós mesmos?\r\nBut a monster to ourselves?\r\n\r\nE se eu for o monstro\r\nWhat if I'm the monster\r\n\r\n\r\nO ciclope fica cheio de culpa quando mata?\r\nIs the Cyclops struck with guilt when he kills?\r\n\r\nEle fica acordado no meio da noite?\r\nIs he up in the middle of the night?\r\n\r\nOu ele acaba com meus homens para vingar sua amiga\r\nOr does he end my men to avenge his friend\r\n\r\nE então dorme sabendo que ele fez certo?\r\nAnd then sleep knowing he has done him right?\r\n\r\n\r\nQuando a bruxa transforma homens em porcos para proteger suas ninfas\r\nWhen the witch turns men to pigs to protect her nymphs\r\n\r\nEla está ficando louca?\r\nIs she going insane?\r\n\r\nOu ela aprendeu a ser mais fria quando ficou mais velha e agora poupa elas da dor?\r\nOr did she learn to be colder when she got older and now she saves them the pain?\r\n\r\nQuando um Deus desce e faz uma frota se afogar\r\nWhen a God comes down and makes a fleet drown\r\n\r\nEle está com medo de estar fazendo algo errado?\r\nIs he scared that he's doing something wrong?\r\n\r\nOu ele nos mantém sob controle, então devemos respeitá-lo\r\nOr does he keep us in check so we must respect him\r\n\r\nE agora ninguém se atreve a irritá-lo?\r\nAnd now no one dares to piss him off?\r\n\r\nUm soldado usa um cavalo de madeira para matar troianos adormecidos porque ele é vil?\r\nDoes a soldier use a wooden horse to kill sleeping trojans cause he is vile?\r\n\r\nOu ele joga fora seu remorso e salva mais vidas com astúcia\r\nOr does he throw away his remorse and save more lives with guile\r\n\r\n\r\nSe eu me tornasse o monstro e jogasse fora essa culpa\r\nIf I became the monster, and threw that guilt away\r\n\r\nIsso nos tornaria mais fortes?\r\nWould that make us stronger?\r\n\r\nIsso manteria nossos inimigos afastados?\r\nWould it keep our foes at bay?\r\n\r\nSe eu me tornasse o monstro para todos menos para nós\r\nIf I became the monster to everyone but us\r\n\r\nE garantimos que chegássemos em casa novamente\r\nAnd made sure we got home again\r\n\r\nQuem se importaria se somos injustos\r\nWho would care if we're unjust?\r\n\r\nSe eu me tornasse o\r\nIf I became the\r\n\r\n\r\n[Soldados]\r\n[Soldiers]\r\n\r\nMonstro\r\nMonster\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nOh, crueldade é misericórdia para nós mesmos\r\nOh, ruthlessness is mercy upon ourselves\r\n\r\n\r\n[Soldados]\r\n[Soldiers]\r\n\r\nMonstro\r\nMonster\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nE no fundo eu sei bem disso\r\nAnd deep down I know this well\r\n\r\nEu perdi meu melhor amigo\r\nI lost my best friend\r\n\r\nPerdi minha mentora, minha mãe\r\nI lost my mentor, my mom\r\n\r\n500 homens se foram, isso não pode continuar\r\n500 men gone, this can't go on\r\n\r\nPreciso ver Penélope e Telêmaco\r\nI must get to see Penelope and Telemachus\r\n\r\nEntão, se tivermos que navegar por oceanos e praias perigosas\r\nSo if we must sail through dangerous oceans and beaches\r\n\r\nEu irei onde Poseidon não nos alcançará\r\nI'll go where Poseidon won't reach us\r\n\r\nE se eu tiver que derrubar outra criança da torre\r\nAnd if I gotta drop another infant from a wall\r\n\r\nPara que todos não morramos\r\nIn an instant so we all don't die\r\n\r\n\r\n[Odisseu e todos]\r\n[Odysseus and all]\r\n\r\nEntão eu me tornarei o\r\nThen I'll become the\r\n\r\nMonstro\r\nMonster\r\n\r\nEu vou dar o golpe\r\nI will deal the blow\r\n\r\nE eu me tornarei o\r\nAnd I'll become the\r\n\r\nMonstro\r\nMonster\r\n\r\nComo nenhum que eles já conheceram\r\nLike none they've ever known\r\n\r\nE daí se eu sou o\r\nSo what if I'm the\r\n\r\nMonstro\r\nMonster\r\n\r\nEspreitando bem abaixo?\r\nLurking deep below?\r\n\r\n\r\nEu devo me tornar o\r\nI must become the\r\n\r\nMonstro\r\nMonster\r\n\r\nE então chegaremos em casa\r\nAnd then we'll make it home\r\n\r\nMonstro\r\nMonster\r\n\r\nPenelope\r\nPenelope\r\n\r\nMonstro\r\nMonster\r\n\r\nTelêmaco\r\nTelemachus\r\n\r\nMonstro\r\nMonster\r\n\r\nOh, crueldade é misericórdia sobre nós mesmos\r\nOh, ruthlessness is mercy upon ourselves\r\n\r\nMonstro\r\nMonster\r\n\r\nEu vou me tornar o monstro\r\nI'll become the monster";
        }
    }
}
