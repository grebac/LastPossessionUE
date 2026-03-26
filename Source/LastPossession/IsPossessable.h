// Fill out your copyright notice in the Description page of Project Settings.  
#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "IsPossessable.generated.h"

UINTERFACE(MinimalAPI, Blueprintable)
class UIsPossessable : public UInterface
{
    GENERATED_BODY()
};


class IIsPossessable
{
    GENERATED_BODY()
private:
    /* data */
public:
    /** Function to be called when the object takes damage from a hit. Implemented by possessable actors. */
    UFUNCTION(BlueprintNativeEvent,BlueprintCallable, Category = "Damage")
    void TakingDamageFromHit(bool bIsFromPlayer, AActor* DamagingActor, float DamageAmount, FHitResult HitInfo);
    
    // Add interface functions to this class. This is the class that will be inherited to implement this interface.
};
    