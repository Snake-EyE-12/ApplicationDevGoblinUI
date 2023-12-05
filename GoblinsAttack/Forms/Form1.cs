namespace GoblinsAttack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            classSelection.DataSource = Enum.GetValues(typeof(CharacterClass));
            Shown += OnShown;
            FormClosed += OnFormClosed;
            this.LostFocus += OnFormClosed;

        }
        private void OnFormClosed(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void healthSkill_Click(object sender, EventArgs e)
        {
            PlayerCreationManager.IncreaseStat(Statistic.Health, 1);
            updateSkillPoints();
        }
        private void damageSkill_Click(object sender, EventArgs e)
        {
            PlayerCreationManager.IncreaseStat(Statistic.Damage, 1);
            updateSkillPoints();
        }
        private void magicSkill_Click(object sender, EventArgs e)
        {
            PlayerCreationManager.IncreaseStat(Statistic.Magic, 1);
            updateSkillPoints();
        }

        private void stealthSkill_Click(object sender, EventArgs e)
        {
            PlayerCreationManager.IncreaseStat(Statistic.Stealth, 1);
            updateSkillPoints();
        }

        private void updateSkillPoints()
        {
            skillPointsLabel.Text = ("Skill Points Remaining: " + PlayerCreationManager.skillPoints);
            healthSkill.Value = PlayerCreationManager.currentHealthBar;
            damageSkill.Value = PlayerCreationManager.currentDamageBar;
            magicSkill.Value = PlayerCreationManager.currentMagicPowerBar;
            stealthSkill.Value = PlayerCreationManager.currentStealthBar;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Game.confirmPlayer(PlayerCreationManager.currentHealthBar, PlayerCreationManager.currentDamageBar, PlayerCreationManager.currentMagicPowerBar, PlayerCreationManager.currentStealthBar, (CharacterClass)classSelection.SelectedItem);
        }

        private void classSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnShown(object? sender, EventArgs e)
        {
            updateSkillPoints();
        }
    }
}