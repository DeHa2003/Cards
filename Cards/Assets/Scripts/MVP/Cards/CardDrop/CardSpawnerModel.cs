using System;

public class CardSpawnerModel
{
    public event Action<CardValue> OnSpawnCard_Values;
    public event Action OnSpawnCard;

    private CardValues cardValues;

    public CardSpawnerModel(CardValues cardValues)
    {
        this.cardValues = cardValues;
    }

    public void SpawnCard()
    {
        CardValue cardValue = cardValues.GetRandom();

        OnSpawnCard_Values?.Invoke(cardValue);
        OnSpawnCard?.Invoke();
    }
}
