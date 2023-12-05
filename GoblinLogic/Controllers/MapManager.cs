using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GoblinsAttack;
public class MapManager
{
    private MapState currentState = MapState.Intro;
    private Form dialogueForm = new DialogueForm();
    private Form battleForm = new BattleForm();
    private Form rewardForm = new RewardForm();
    private Form overForm = new OverForm();
    private Form begin = new Form1();

    public void ChangeState(MapState state)
    {
        currentState = state;
        if (state == MapState.Intro)
        {
            hideForm(dialogueForm);
            hideForm(battleForm);
            hideForm(rewardForm);
            hideForm(overForm);
            begin = new Form1();
            focusForm(begin);
        }
        else if (state == MapState.Dialogue)
        {
            hideForm(begin);
            hideForm(battleForm);
            hideForm(rewardForm);
            hideForm(overForm);
            dialogueForm = new DialogueForm();
            focusForm(dialogueForm);

        }
        else if (state == MapState.Fight)
        {
            hideForm(begin);
            hideForm(dialogueForm);
            hideForm(rewardForm);
            hideForm(overForm);
            battleForm = new BattleForm();
            focusForm(battleForm);
        }
        else if (state == MapState.Over)
        {
            hideForm(begin);
            hideForm(dialogueForm);
            hideForm(rewardForm);
            hideForm(battleForm);
            overForm = new OverForm();
            focusForm(overForm);
        }
        else if (state == MapState.Reward)
        {
            hideForm(begin);
            hideForm(dialogueForm);
            hideForm(overForm);
            hideForm(battleForm);
            rewardForm = new RewardForm();
            focusForm(rewardForm);
        }
        else
        {
            hideForm(begin);
            hideForm(dialogueForm);
            hideForm(battleForm);
            hideForm(rewardForm);
            hideForm(overForm);
        }
    }
    private void hideForm(Form form)
    {
        form.Hide();
    }
    private void closeForm(Form form)
    {
        form.Close();
    }
    private void focusForm(Form form)
    {
        form.Show();
    }
    public void CloseAll()
    {
        begin.Close();
        dialogueForm.Close();
        battleForm.Close();
        rewardForm.Close();
        overForm.Close();
        Application.Exit();
    }
}

public enum MapState
{
    Intro,
    Dialogue,
    Fight,
    Reward,
    Over
}