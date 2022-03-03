from django.shortcuts import render
from django.views.decorators.csrf import csrf_exempt
from rest_framework.parsers import JSONParser
from django.http.response import JsonResponse

from FirstComponent.models import Register
from FirstComponent.serializer import RegisterSerializer
# Create your views here.




