from django.shortcuts import render
from django.views.decorators.csrf import csrf_exempt
from rest_framework.parsers import JSONParser
from django.http.response import JsonResponse

from FirstComponent.models import Register
from FirstComponent.serializer import RegisterSerializer
# Create your views here.



@csrf_exempt
def RegisterApi(request,id=0):
    if request.method=='GET':
        register = Register.objects.all()
        register_serializer = RegisterSerializer(register, many=True)
        return JsonResponse(register_serializer.data, safe=False)
    elif request.method=='POST':
        register_data = JSONParser().parse(request)
        register_serializer = RegisterSerializer(data=register_data)
        if register_serializer.is_valid():
            register_serializer.save()
