using System.Collections.Generic;
using UnityEngine;

public class Beggar : NPC {
    public override string npcName { get; set; } = "Beggar";
    private bool beenPaid = false;
    public override void RevealName() {}

    public void BeenPaid(bool value) {
        beenPaid = value;
    }

    public void Steal(int value) {
        GameManager.money += value;
    }

    public void Pay(int value) {
        GameManager.money -= value;
    }
}