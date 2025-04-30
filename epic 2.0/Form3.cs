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
    public partial class Form3 : Form
    {
        public Form3()
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
            string caminho = @"C:\Users\DB\Desktop\epic videos\polyphemus.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Polifemo\r\nPolyphemus\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nPor aqui!\r\nOver here!\r\n\r\n\r\n[Polites]\r\n[Polites]\r\n\r\nVejam toda essa comida, vejam todas essas ovelhas\r\nLook at all this food, look at all these sheep\r\n\r\nEu nem acredito que essa caverna tem tudo isso para nós ficarmos\r\nI can't believe this cave has all this for us to keep\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nEu tenho que admitir para vocês dois, isso é muito bom\r\nI've gotta hand it to you both, this is quite the treat\r\n\r\nTêm ovelhas suficientes aqui para alimentar toda a frota\r\nThere are enough sheep here to feed the entire fleet\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nÉ quase perfeito demais, bom demais para ser verdade\r\nIt's almost too perfect, too good to be true\r\n\r\nPor que os comedores de Lótus deixariam pra lá toda essa comida?\r\nWhy would the lotus eaters pass up on all this food?\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nQuem são vocês?\r\nWho are you?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEaí\r\nHey there\r\n\r\nSomos apenas viajantes\r\nWe're just travellers\r\n\r\nNós viemos em paz\r\nWe come in peace\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nVocês mataram minha ovelha\r\nYou killed my sheep\r\n\r\nMinha ovelha favorita\r\nMy favouritе sheep\r\n\r\nO que lhes dá o direito de causar tanta dor?\r\nWhat gives you the right to deal a pain so deep\r\n\r\nVocês não sabem que a dor que semeiam é a dor que colhem?\r\nDon't you know that pain you sow is pain you rеap?\r\n\r\n\r\nHora de beber\r\nTime to drink\r\n\r\nSeu sangue de onde vocês estão\r\nYour blood over where you stand\r\n\r\nSuas vidas estão nas minhas mãos\r\nYour life now is in my hand\r\n\r\nAntes que eu termine\r\nBefore I'm done\r\n\r\nVocês vão aprender que não é tão divertido roubar\r\nYou will learn that it's not so fun to take\r\n\r\nVocês vieram até a minha casa para roubar\r\nYou came to my home to steal\r\n\r\nMas agora virarão minha refeição\r\nBut now you'll become my meal\r\n\r\nUma troca, você vê?\r\nA trade, you see?\r\n\r\nTirar de você como você tirou de mim\r\nTake from you like you took from me\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nHouve um desentendimento\r\nThere's been a misunderstanding\r\n\r\nNós nunca viemos aqui para roubar\r\nWe never came here to steal\r\n\r\nMas agora que vejo que causamos danos\r\nBut now that I see we've done some damage\r\n\r\nTalvez você e eu possamos fazer um acordo\r\nMaybe you and I could make a deal\r\n\r\nEu lhe darei nosso melhor tesouro\r\nI'll give you our finest treasure\r\n\r\nDesde que saiamos daqui vivos\r\nSo long as we leave alive\r\n\r\nVocê pode ficar com o vinho mais gostoso do mundo\r\nYou can keep the world's best tasting wine\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nVinho?\r\nWine?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nTome um drinque\r\nHave a drink\r\n\r\nUm gole e você entenderá\r\nOne sip and you'll understand\r\n\r\nO poder que está nas suas mãos\r\nThe power that's in your hands\r\n\r\nUm vinho tão fresco\r\nA wine so fresh\r\n\r\nQue você nunca mais vai querer comer carne humana\r\nYou'd never wanna eat human flesh again\r\n\r\nEntão nós vamos seguir nosso caminho\r\nThen we shall be on our way\r\n\r\nSem derramamento de sangue aqui hoje\r\nNo bloodshed in here today\r\n\r\nUma troca, você vê?\r\nA trade, you see?\r\n\r\nUm presente seu e um presente meu\r\nA gift from you and a gift from me\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nAh, eu gostaria de lhe agradecer\r\nAh, I'd like to thank you\r\n\r\nEstranho, qual seu nome?\r\nStranger, what's your name?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nMeu nome é Ninguém, Ninguém, Ninguém\r\nMy name is nobody, nobody, nobody\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nNinguém, pelo seu presente eu gostaria de responder\r\nNobody, for your gift I've one to reply\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEstou tão feliz que vemos olho por olho\r\nI'm so glad we see eye to eye\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nSim, você será o último homem a morrer\r\nYes, you shall be the final man to die\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nO que?\r\nWhat?\r\n\r\nCuidado!\r\nWatch out!\r\n";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\DB\Desktop\epic videos\survive.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Sobreviver\r\nSurvive\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nMeus irmãos\r\nMy brothers\r\n\r\nO resto da nossa frota\r\nThe rest of our fleet\r\n\r\nEles esperam na praia\r\nThey wait at the beach\r\n\r\nE se formos derrotados, eles estarão mortos\r\nAnd if we're defeated, they’re good as dead\r\n\r\nBem em frente, é contra isso que estamos lutando\r\nStraight ahead, that is who we're fighting\r\n\r\n\r\nSem ajuda, sem chance de suporte\r\nNo backup, no chance for support\r\n\r\nEntão desembainhem suas espadas\r\nSo draw out your swords\r\n\r\nNosso inimigo deve ser frustrado aqui e agora\r\nOur foe must be thwarted right here and now\r\n\r\nMostrem-me quão grande é sua vontade de sobreviver\r\nShow me how great is your will to survive\r\n\r\n\r\nSeiscentas vidas em jogo\r\nSix hundred lives at stake\r\n\r\nÉ só uma vida para tirar\r\nIt's just one life to take\r\n\r\nE quando o matarmos, nossa jornada terminará\r\nAnd when we kill him then our journey’s over\r\n\r\nNão vou morrer agora\r\nNo dying on me now\r\n\r\nA derrota não é permitida\r\nDefeat is not allowed\r\n\r\nDevemos viver este dia, então\r\nWe must live through this day so\r\n\r\nLutem, lutem, lutem\r\nFight, fight, fight\r\n\r\n\r\n[Odisseu e tripulação]\r\n[Odysseus and crew]\r\n\r\nCerque-o (cerque-o)\r\nSurround him (surround him)\r\n\r\nAtaque por trás, mantenha a distância em mente\r\nAttack from behind, keep distance in mind\r\n\r\nE fique em seu ponto cego e bata em seus calcanhares (bata nos calcanhares)\r\nAnd stay in his blindspot and strike his heels (strike the heels)\r\n\r\nMostre a ele que somos mortais\r\nShow him that we're deadly\r\n\r\n\r\nEsgote-o (esgote-o)\r\nExhaust him (exhaust him)\r\n\r\nNão deixe ele chegar perto, ele é forte mas é lento\r\nDon't let him get close, he's strong but he's slow\r\n\r\nEle não pode nos dar um golpe se estivermos fora de alcance\r\nHe can't land a blow if we're out of reach\r\n\r\nEncontre uma brecha\r\nFind a breach\r\n\r\nLevante-se e lute por suas vidas\r\nStand up and fight for your lives\r\n\r\n\r\nSeiscentas vidas em jogo\r\nSix hundred lives at stake\r\n\r\nÉ só uma vida para tirar\r\nIt's just one life to take\r\n\r\nE quando o matarmos, nossa jornada terminará\r\nAnd when we kill him then our journey’s over\r\n\r\n(Em frente)\r\n(Push forward)\r\n\r\nNão vamos morrer agora\r\nNo dying on us now\r\n\r\nA derrota não é permitida\r\nDefeat is not allowed\r\n\r\nDevemos viver este dia, então\r\nWe must live through this day so\r\n\r\nLutem, lutem, lutem\r\nFight, fight, fight\r\n\r\n\r\n[Polites]\r\n[Polites]\r\n\r\nCapitão\r\nCaptain\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nBasta\r\nEnough\r\n\r\n\r\n[Tripulação]\r\n[Crew]\r\n\r\nEle tem um porrete\r\nHe’s got a club\r\n\r\nEle tem um porrete!\r\nHe's got a club!\r\n\r\nQuais são nossas ordens?\r\nWhat are our orders?\r\n\r\nCapitão? Capitão!\r\nCaptain? Captain!\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nVocê já me machucou o suficiente\r\nYou’ve hurt me enough\r\n\r\nSeiscentas vidas eu vou tirar\r\nSix hundred lives I'll take\r\n\r\nSeiscentas vidas eu vou quebrar\r\nSix hundred lives I'll break\r\n\r\nE quando eu te matar, minha dor terminará\r\nAnd when I kill you then my pain is over\r\n\r\nVocê vai morrer aqui e agora\r\nYou're dying here and now\r\n\r\nFuga não é permitida\r\nEscape is not allowed\r\n\r\nVocê não vai sobreviver a este dia, agora morra\r\nYou won’t live through this day now die\r\n\r\nMorra\r\nDie\r\n";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\DB\Desktop\epic videos\remember them.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Lembre-se Deles\r\nRemember Them\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nCapitão!\r\nCaptain!\r\n\r\nCapitão!\r\nCaptain!\r\n\r\nCapitão!\r\nCaptain!\r\n\r\nCapitão!\r\nCaptain!\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nTemos que agir rápido, não temos muito tempo\r\nWe must move quickly, we don't have much time\r\n\r\nEle não percebeu que eu misturei lótus em seu vinho\r\nHe didn't notice I mixed lotus in his wine\r\n\r\nMarque minhas palavras agora, este não é o fim\r\nMark my words now, this is not the end\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nMas capitão, o que faremos com nossos amigos caídos?\r\nBut captain, what'll we do with our fallen friends?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nQuando o fogo começa a apagar\r\nWhen the fire begins to fade\r\n\r\nPara os caídos e desgastados\r\nFor the fallen and afraid\r\n\r\nNão devemos deixá-los morrer em vão\r\nWe are not to let them die in vain\r\n\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nNós somos aqueles que continuam\r\nWe're the ones who carry on\r\n\r\nAs chamas daqueles que se foram\r\nThe flames of those who've gone\r\n\r\nE nossos camaradas não morrerão em vão\r\nAnd our comrades will not die in vain\r\n\r\n\r\nPreciso de todas as nossas mãos no clube dele\r\nI need all our hands on his club\r\n\r\nÉ assim que vamos sair daqui\r\nThis is how we're getting out of here\r\n\r\nUse suas espadas para afiar o toco\r\nUse your swords to sharpen the stub\r\n\r\nE transformá-lo em uma lança gigante\r\nAnd turn it to a giant spear\r\n\r\n\r\n[Tripulação]\r\n[Crew]\r\n\r\nVamos matá-lo!\r\nLet's kill him!\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nSeu corpo está bloqueando o caminho\r\nHis body is blocking the path\r\n\r\nSe o matarmos ficaremos presos lá dentro\r\nIf we kill him we'll be stuck inside\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nCapitão, onde o atacamos?\r\nCaptain, where do we attack him?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nTemos que esfaqueá-lo no olho\r\nWe gotta stab him in the eye\r\n\r\n\r\n[Tripulação]\r\n[Crew]\r\n\r\nSim, senhor\r\nYes sir\r\n\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nQuando o fogo começa a apagar\r\nWhen the fire begins to fade\r\n\r\nPara os caídos e desgastados\r\nFor the fallen and afraid\r\n\r\nNão devemos deixá-los morrer em vão\r\nWe are not to let them die in vain\r\n\r\n\r\n[Odisseu e tripulação]\r\n[Odysseus and crew]\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nNós somos aqueles que continuam\r\nWe're the ones who carry on\r\n\r\nAs chamas daqueles que se foram\r\nThe flames of those who've gone\r\n\r\nE nossos camaradas não morrerão em vão\r\nAnd our comrades will not die in vain\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nAgora!\r\nNow!\r\n\r\nEspalhem!\r\nScatter!\r\n\r\n\r\n[Ciclopes]\r\n[Cyclopes]\r\n\r\nQuem te machuca?\r\nWho hurts you?\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nHá mais deles?\r\nThere are more of them?\r\n\r\n\r\n[Ciclopes]\r\n[Cyclopes]\r\n\r\nQuem te machuca?\r\nWho hurts you?\r\n\r\n\r\n[Odisseu, sussurrando]\r\n[Odysseus, whispering]\r\n\r\nEsconda-se!\r\nHide!\r\n\r\n\r\n[Ciclopes]\r\n[Cyclopes]\r\n\r\nQuem te machuca?\r\nWho hurts you?\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nCapitão, devemos correr\r\nCaptain, we should run\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEspere!\r\nWait!\r\n\r\n\r\n[Ciclopes]\r\n[Cyclopes]\r\n\r\nQuem te machuca?\r\nWho hurts you?\r\n\r\n\r\n[Euríloco]\r\n[Eurylochus]\r\n\r\nCapitão, por favor!\r\nCaptain, please!\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEspere!\r\nWait!\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nNão era ninguém, ninguém\r\nIt was Nobody, Nobody\r\n\r\n\r\n[Ciclopes]\r\n[Cyclopes]\r\n\r\nSe ninguém te machucar, fique em silêncio\r\nIf nobody hurts you, be silent\r\n\r\n\r\n[Polifemo]\r\n[Polyphemus]\r\n\r\nNão vá!\r\nDon’t go!\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nVamos pegar as ovelhas e vamos embora\r\nLet's grab the sheep and away we go\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nVocê se esqueceu das lições que lhe ensinei?\r\nHave you forgotten the lessons I taught you?\r\n\r\nEle ainda é uma ameaça até morrer\r\nHe's still a threat until he's dead\r\n\r\nTermine isso\r\nFinish it\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nNão\r\nNo\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nNão?\r\nNo?\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nDe que adiantaria matar\r\nWhat good would killing do\r\n\r\nQuando a misericórdia é uma habilidade que mais pessoas deste mundo poderiam aprender a usar\r\nWhen mercy is a skill more of this world could learn to use\r\n\r\nMeu amigo está morto, nosso inimigo está cego\r\nMy friend is dead, our foe is blind\r\n\r\nO sangue que derramamos nunca seca\r\nThe blood we shed, it never dries\r\n\r\nÉ isso que significa ser um guerreiro da mente?\r\nIs this what it means to be a warrior of the mind?\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nNão!\r\nDon't!\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nEi, Ciclope!\r\nHey, Cyclops!\r\n\r\nQuando nos conhecemos, eu liderei com paz\r\nWhen we met, I led with peace\r\n\r\nEnquanto você alimentava sua fera interior\r\nWhile you fed your inner beast\r\n\r\nMas meus camaradas não morrerão em vão\r\nBut my comrades will not die in vain\r\n\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nDa próxima vez que você ousar escolher não poupar\r\nThe next time that you dare choose not to spare\r\n\r\nLembre-se deles\r\nRemember them\r\n\r\nLembre-se de nós\r\nRemember us\r\n\r\nLembre de mim\r\nRemember me\r\n\r\n\r\nEu sou o rei reinante de Ítaca\r\nI'm the reigning king of Ithaca\r\n\r\nNão sou nem homem nem mítico\r\nI am neither man nor mythical\r\n\r\nEu sou seu momento mais sombrio\r\nI am your darkest moment\r\n\r\nEu sou o infame\r\nI am the infamous\r\n\r\nOdisseu\r\nOdysseus\r\n";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string caminho = @"C:\Users\DB\Desktop\epic videos\my goodbye.mp4"; // Troque pelo nome real

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
            textBox1.Text = "Meu Adeus\r\nMy Goodbye\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nVocê foi imprudente, sentimental na melhor das hipóteses\r\nYou were reckless, sentimental at best\r\n\r\nNão foi isso que eu te ensinei\r\nThat's not a teaching of mine\r\n\r\nVocê amoleceu, seus amigos mortos podem comprovar\r\nYou’ve grown soft, your dead friends can attest\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\n(Ei!)\r\nHey!\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nColoque suas emoções de lado\r\nPut your emotions aside\r\n\r\nVocê é um guerreiro, destinado a liderar o resto\r\nYou're a warrior meant to lead the rest\r\n\r\nEu não sei onde foi que eu errei\r\nI don't know where I went wrong\r\n\r\nMas eu te avisei e você falhou no teste\r\nBut I warned you, and you failed the test\r\n\r\nEntão agora estou indo embora\r\nSo now I'm gone\r\n\r\n\r\nDesse jeito, você vai se colocar no seu lugar\r\nThis way, you'll know what your place is\r\n\r\nDesse jeito, você não vai ultrapassar o limite\r\nThis way, you can't cross the line\r\n\r\nDesse jeito, quando tudo acabar, você vai ficar com o que é seu e eu com que é meu\r\nThis way, when all is over you'll keep yours and I'll keep mine\r\n\r\nDesse jeito, você não vai me decepcionar\r\nThis way, you won't disappoint me\r\n\r\nDesse jeito, você não vai desperdiçar meu tempo\r\nThis way, you won't waste my time\r\n\r\nDesse jeito, eu fecho essa porta\r\nThis way, I'll close the door\r\n\r\nConsidere isso meu adeus\r\nConsider this as my goodbye\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nIsso é tão você, por que eu deveria estar surpreso?\r\nThat’s just like you, why should I be surprised?\r\n\r\nEgoísta, orgulhosa e vaidosa\r\nSelfish and prideful and vain\r\n\r\nDiferente de você, todas as vezes que alguém morre\r\nUnlike you, every time someone dies\r\n\r\nSou eu quem deve lidar com o choque\r\nI'm left to deal with the strain\r\n\r\nO que uma deusa poderia me oferecer se eu nunca vou dormir à noite?\r\nWhat's a title that a goddess could lend if I’ll never sleep at night?\r\n\r\nVou te lembrar que eu considerava você como uma amiga\r\nI'll remind you I saw you as a friend\r\n\r\nMas agora tudo acabou\r\nBut now we're done\r\n\r\n\r\nDesse jeito, você esta fora da minha cabeça agora\r\nThis way, you're out of my head now\r\n\r\nDesse jeito, você não vai mais importunar minha vida\r\nThis way, you won’t plague my life\r\n\r\nDesse jeito, quando tudo acabar, você estará fora de vista e fora da minha mente\r\nThis way, when all is done, you're out of sight and out of mind\r\n\r\nDesse jeito, você vai conseguir o que queria\r\nThis way, you get what you wanted\r\n\r\nDesse jeito, você não vai mais desperdiçar seu tempo\r\nThis way, you can save your time\r\n\r\nDesse jeito, você colocou um ponto final e vai ter a merda do seu adeus\r\nThis way, you close the door and have your damn goodbye\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nVocê não está procurando uma mentora\r\nYou're not looking for a mentor\r\n\r\nEu não estou procurando por um amigo\r\nI'm not looking for a friend\r\n\r\nEu confundi você com um general\r\nI mistook you for a general\r\n\r\nQue desperdício de esforço\r\nWhat a waste of effort spent\r\n\r\n\r\n[Odisseu]\r\n[Odysseus]\r\n\r\nPelo menos sei pelo que estou lutando\r\nAt least I know what I'm fighting for\r\n\r\nEnquanto você só luta para ser reconhecida\r\nWhile you're fighting to be known\r\n\r\nJá que você se diz tão mais sábia\r\nSince you claim you're so much wiser\r\n\r\nPor que passa sua vida sozinha?\r\nWhy's your life spent all alone?\r\n\r\nVocê esta sozinha\r\nYou're alone\r\n\r\n\r\n[Atena]\r\n[Athena]\r\n\r\nUm dia, você vai ouvir o que estou dizendo\r\nOne day, you'll hear what I'm saying\r\n\r\nUm dia, talvez você entenda\r\nOne day, you might understand\r\n\r\nUm dia, mas não hoje, por que apesar de tudo você é\r\nOne day, but not today, for after all you're\r\n\r\n\r\n[Coro]\r\n[Ensemble]\r\n\r\nApenas um homem\r\nJust a man\r\n\r\n\r\n[Atena e Coro]\r\n[Athena and Ensemble]\r\n\r\nA partir de hoje, você comanda o próprio destino\r\nThis day, you sever your own head\r\n\r\nA partir de hoje, você cortou nosso laço\r\nThis day, you cut the line\r\n\r\nA partir de hoje, você perdeu tudo\r\nThis day, you lost it all\r\n\r\nConsidere isso meu adeus\r\nConsider this as my goodbye\r\n\r\nOh\r\nOh\r\n\r\nConsidere isso meu adeus\r\nConsider this as my goodbye\r\n\r\nOh\r\nOh\r\n\r\nEsse é meu adeus\r\nThis is my goodbye\r\n\r\nOh\r\nOh\r\n\r\nConsidere isso meu adeus\r\nConsider this as my goodbye\r\n\r\nOh\r\nOh\r\n\r\nEsse é meu adeus\r\nThis is my goodbye\r\n";
        }
    }
}
