az group create --location westeurope -n GRgrupo
az storage account create -g GRgrupo -l westeurope -n sastoragecdp --sku Standard_LRS --kind StorageV2
az functionapp create --consumption-plan-location westeurope --name funcioncdp --os-type Windows --resource-group GRgrupo --runtime dotnet --storage-account sastoragecdp