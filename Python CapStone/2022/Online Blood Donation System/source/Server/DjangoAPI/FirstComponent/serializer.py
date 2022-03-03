from rest_framework import serializers
from FirstComponent.models import Register

class RegisterSerializer(serializers.ModelSerializer):

    class Meta:
        model = Register
        field = {'id',
                 'firstname',
                 'lastname',
                 'dataOfBirth',
                 'email',
                 'phone',
                 'country',
                 'state',
                 'area',
                 'address',
                 'pincode',
                 'password'
                    }